using CSharpFunctionalExtensions;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WeatherAPI.Configurations;
using WeatherAPI.Dtos;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IMongoCollection<WeatherForecastDto> _forecasts;

        public WeatherForecastService(IOptions<MongoDbConfiguration> mongoDbConfiguration)
        {
            var client = new MongoClient(mongoDbConfiguration.Value.ConnectionString);
            var database = client.GetDatabase(mongoDbConfiguration.Value.DatabaseName);
            _forecasts = database.GetCollection<WeatherForecastDto>("Forecasts");
        }

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
