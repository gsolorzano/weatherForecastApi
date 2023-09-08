using CSharpFunctionalExtensions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WeatherAPI.Configurations;
using WeatherAPI.Dtos;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
    /// <summary>
    /// WeatherForecastService class.
    /// </summary>
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IMongoCollection<WeatherForecastDto> _forecasts;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecastService"/> class.
        /// </summary>
        /// <param name="mongoDbConfiguration">The MongoDbConfiguration.</param>
        public WeatherForecastService(IOptions<MongoDbConfiguration> mongoDbConfiguration)
        {
            var client = new MongoClient(mongoDbConfiguration.Value.ConnectionString);
            var database = client.GetDatabase(mongoDbConfiguration.Value.DatabaseName);
            _forecasts = database.GetCollection<WeatherForecastDto>("Forecasts");
        }

        /// <inheritdoc/>
        public Result<List<WeatherForecastDto>> GetWeatherForecasts()
        {
            try
            {
                var forecasts = _forecasts.Find(forecast => true).ToList();
                return Result.Success(forecasts);
            }
            catch (Exception ex)
            {
                return Result.Failure<List<WeatherForecastDto>>(ex.Message);
            }
        }

        /// <inheritdoc/>
        public Result InsertWeatherForecasts(List<WeatherForecastDto> weatherForecastDtos)
        {
            {
                try
                {
                    _forecasts.InsertMany(weatherForecastDtos);
                    return Result.Success();
                }
                catch (Exception ex)
                {
                    return Result.Failure<List<WeatherForecastDto>>(ex.Message);
                }
            }
        }
    }
}
