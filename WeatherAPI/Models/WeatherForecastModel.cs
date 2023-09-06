using CSharpFunctionalExtensions;
using WeatherAPI.Dtos;
using WeatherAPI.Models.Interfaces;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Models
{
	public class WeatherForecastModel : IWeatherForecastModel
	{
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastModel(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        public Result<List<WeatherForecastDto>> GetWeatherForecasts()
        {
            try
            {
                var forecast = _weatherForecastService.GetWeatherForecasts();
                if (forecast.IsFailure)
                {
                    return Result.Failure<List<WeatherForecastDto>>("Failed to fetch weather data");
                }

                return forecast;
            }
            catch (Exception)
            {
                return Result.Failure<List<WeatherForecastDto>>("An exception occured while fetching the weather data");
            }
        }
    }
}

