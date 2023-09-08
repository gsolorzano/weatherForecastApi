using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WeatherAPI.Dtos;
using WeatherAPI.Models.Interfaces;

namespace WeatherAPI.Controllers
{
    /// <summary>
    /// WeatherForecastController Class.
    /// </summary>
    [ApiController]
    [Route("api/weather")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastModel _weatherForecastModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherForecastController"/> class.
        /// </summary>
        /// <param name="weatherForecastModel">The Weather Forecast Model.</param>
        public WeatherForecastController(IWeatherForecastModel weatherForecastModel)
        {
            _weatherForecastModel = weatherForecastModel;
        }

        /// <summary>
        /// Gets all the weather forecasts in the mongo DB.
        /// </summary>
        /// <returns>An <see cref="IActionResult"/>.</returns>
        [HttpGet("forecasts")]
        [SwaggerOperation(Summary = "Fetches weather forecasts.")]
        [SwaggerResponse(200, "The weather forecasts were successfully retrieved.", typeof(List<WeatherForecastDto>))]
        [SwaggerResponse(400, "The request is bad.")]
        [SwaggerResponse(404, "Weather forecasts not found.")]
        public IActionResult GetWeatherForecasts()
        {
            var weatherForecastResult = _weatherForecastModel.GetWeatherForecasts();

            if (weatherForecastResult.IsFailure)
            {
                return BadRequest(weatherForecastResult.Error);
            }

            return Ok(weatherForecastResult.Value);
        }

        /// <summary>
        /// Creates a set of new weather forecasts.
        /// </summary>
        /// <param name="createWeatherForecastsDtos">The list of weather forecasts to create.</param>
        /// <returns>An <see cref="IActionResult"/>.</returns>
        [HttpPost("forecasts")]
        [SwaggerOperation(Summary = "Creates weather forecasts.")]
        [SwaggerResponse(200, "The weather forecasts were successfully created.")]
        [SwaggerResponse(400, "The request is bad.")]
        [SwaggerResponse(422)]
        public IActionResult CreateWeatherForecasts([FromBody] List<CreateWeatherForecastDto> createWeatherForecastsDtos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var creationResult = _weatherForecastModel.CreateWeatherForecasts(createWeatherForecastsDtos);

            if (creationResult.IsFailure)
            {
                return UnprocessableEntity(creationResult.Error);
            }

            return Ok();
        }
    }
}
