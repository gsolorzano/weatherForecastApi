using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WeatherAPI.Dtos;
using WeatherAPI.Models.Interfaces;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherForecastController : ControllerBase
	{
        private readonly IWeatherForecastModel _weatherForecastModel;

		public WeatherForecastController(IWeatherForecastModel weatherForecastModel)
		{
            _weatherForecastModel = weatherForecastModel;
		}

        [HttpGet("forecast")]
        [SwaggerOperation(Summary = "Fetches weather forecasts.")]
        [SwaggerResponse(200, "The weather forecasts were successfully retrieved.", typeof(List<WeatherForecastDto>))]
        [SwaggerResponse(400, "The request is bad.")]
        [SwaggerResponse(404, "Weather forecasts not found.")]
        public IActionResult GetWeatherForecast()
        {
            var weatherForecastResult = _weatherForecastModel.GetWeatherForecasts();

            if (weatherForecastResult.IsFailure)
            {
                return BadRequest(weatherForecastResult.Error);
            }

            return Ok(weatherForecastResult.Value);
        }
    }
}
