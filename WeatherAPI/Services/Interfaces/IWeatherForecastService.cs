using CSharpFunctionalExtensions;
using WeatherAPI.Dtos;

namespace WeatherAPI.Services.Interfaces
{
    /// <summary>
    /// IWeatherForecastService interface.
    /// </summary>
    public interface IWeatherForecastService
    {
        /// <summary>
        /// Gets the weather forecasts from the mongo DB.
        /// </summary>
        /// <returns>The list of WeatherForecastDto fetched from the DB.</returns>
        Result<List<WeatherForecastDto>> GetWeatherForecasts();

        /// <summary>
        /// Inserts a set of WeatherForecastDto into the mongo DB.
        /// </summary>
        /// <param name="weatherForecastDtos">The list of WeatherForecastDto to create.</param>
        /// <returns>The Result of the insert operation.</returns>
        Result InsertWeatherForecasts(List<WeatherForecastDto> weatherForecastDtos);
    }
}
