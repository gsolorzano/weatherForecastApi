using FluentValidation;
using WeatherAPI.Dtos;

namespace WeatherAPI.Validators
{
    /// <summary>
    /// CreateWeatherForecastDtoValidator class.
    /// </summary>
    public class CreateWeatherForecastDtoValidator : AbstractValidator<CreateWeatherForecastDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWeatherForecastDtoValidator"/> class.
        /// </summary>
        public CreateWeatherForecastDtoValidator()
        {
            RuleFor(x => x.Date).NotEmpty();
            RuleFor(x => x.Summary).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(x => x.TemperatureC).InclusiveBetween(-50, 50);
        }
    }
}
