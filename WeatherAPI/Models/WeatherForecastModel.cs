using AutoMapper;
using CSharpFunctionalExtensions;
using WeatherAPI.Dtos;
using WeatherAPI.Models.Interfaces;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Models
{
    /// <summary>
    /// WeatherForecastModel class.
    /// </summary>
    public class WeatherForecastModel : IWeatherForecastModel
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecastModel"/> class.
        /// </summary>
        /// <param name="weatherForecastService">The WeatherForecastService.</param>
        /// <param name="mapper">The Mapper.</param>
        public WeatherForecastModel(IWeatherForecastService weatherForecastService, IMapper mapper)
        {
            _weatherForecastService = weatherForecastService;
            _mapper = mapper;
        }

        /// <inheritdoc/>
        public Result<List<WeatherForecastDto>> GetWeatherForecasts()
        {
            var forecastResult = _weatherForecastService.GetWeatherForecasts();
            if (forecastResult.IsFailure)
            {
                return Result.Failure<List<WeatherForecastDto>>($"Failed to fetch weather data. Error: {forecastResult.Error}");
            }

            return forecastResult;
        }

        /// <inheritdoc/>
        public Result CreateWeatherForecasts(List<CreateWeatherForecastDto> createWeatherForecastDtos)
        {
            var weatherForecastDtos = _mapper.Map<List<WeatherForecastDto>>(createWeatherForecastDtos);

            var creationResult = _weatherForecastService.InsertWeatherForecasts(weatherForecastDtos);

            if (creationResult.IsFailure)
            {
                return Result.Failure($"Failed to create weather data. Error: {creationResult.Error}");
            }

            return Result.Success();
        }
    }
}
