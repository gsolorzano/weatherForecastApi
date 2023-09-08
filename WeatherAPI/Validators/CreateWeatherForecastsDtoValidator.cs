using FluentValidation;
using WeatherAPI.Dtos;

namespace WeatherAPI.Validators
{
    /// <summary>
    /// CreateWeatherForecastsDtoValidator class.
    /// </summary>
    public class CreateWeatherForecastsDtoValidator : AbstractValidator<List<CreateWeatherForecastDto>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWeatherForecastsDtoValidator"/> class.
        /// </summary>
        public CreateWeatherForecastsDtoValidator()
        {
            RuleFor(dto => dto).NotNull().NotEmpty();
            RuleForEach(dto => dto).SetValidator(new CreateWeatherForecastDtoValidator());
        }
    }
}
