using CSharpFunctionalExtensions;
using WeatherAPI.Dtos;

namespace WeatherAPI.Models.Interfaces
{
    /// <summary>
    /// IWeatherForecastModel interface.
    /// </summary>
    public interface IWeatherForecastModel
    {
        /// <summary>
        /// Gets the weather forecasts.
        /// </summary>
        /// <returns>A Result with the list of WeatherForecastDto.</returns>
        Result<List<WeatherForecastDto>> GetWeatherForecasts();

        /// <summary>
        /// Creates a set of weather forecasts.
        /// </summary>
        /// <param name="createWeatherForecastDtos">The list of forecasts to create.</param>
        /// <returns>a Result of the creation operation.</returns>
        Result CreateWeatherForecasts(List<CreateWeatherForecastDto> createWeatherForecastDtos);
    }
}
