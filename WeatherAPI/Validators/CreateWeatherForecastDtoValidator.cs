using FluentValidation;
using WeatherAPI.Dtos;

namespace WeatherAPI.Validators
{
    public class CreateWeatherForecastDtoValidator : AbstractValidator<CreateWeatherForecastDto>
    {
        public CreateWeatherForecastDtoValidator()
        {
            RuleFor(x => x.Date).NotEmpty();
            RuleFor(x => x.Summary).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(x => x.TemperatureC).InclusiveBetween(-50, 50);
        }
    }
}
