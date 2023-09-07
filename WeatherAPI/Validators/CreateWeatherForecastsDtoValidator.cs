using FluentValidation;
using WeatherAPI.Dtos;

namespace WeatherAPI.Validators
{
	public class CreateWeatherForecastsDtoValidator : AbstractValidator<List<CreateWeatherForecastDto>>
    {
		public CreateWeatherForecastsDtoValidator()
		{
			RuleFor(dto => dto).NotNull().NotEmpty();
			RuleForEach(dto => dto).SetValidator(new CreateWeatherForecastDtoValidator());
		}
	}
}

