using CSharpFunctionalExtensions;
using WeatherAPI.Dtos;

namespace WeatherAPI.Models.Interfaces
{
	public interface IWeatherForecastModel
	{
        Result<List<WeatherForecastDto>> GetWeatherForecasts();

        Result CreateWeatherForecasts(List<CreateWeatherForecastDto> createWeatherForecastDtos);
    }
}

