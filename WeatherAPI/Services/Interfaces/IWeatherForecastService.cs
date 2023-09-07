using CSharpFunctionalExtensions;
using WeatherAPI.Dtos;

namespace WeatherAPI.Services.Interfaces
{
	public interface IWeatherForecastService
	{
        Result<List<WeatherForecastDto>> GetWeatherForecasts();

        Result InsertWeatherForecasts(List<WeatherForecastDto> weatherForecastDtos);
    }
}

