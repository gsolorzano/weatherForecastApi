using CSharpFunctionalExtensions;
using WeatherAPI.Dtos;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
	public class WeatherForecastService : IWeatherForecastService
	{
        public Result<List<WeatherForecastDto>> GetWeatherForecasts()
        {
            return new List<WeatherForecastDto>
            {
                new WeatherForecastDto { Date = DateTime.Now, TemperatureC = 21, Summary = "Cloudy" }
            };
        }
    }
}

