using CSharpFunctionalExtensions;
using WeatherAPI.Dtos;

namespace WeatherAPI.Services.Interfaces
{
	public interface IWeatherForecastService
	{
        Result<List<WeatherForecastDto>> GetWeatherForecasts();
	}
}

