using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace WeatherAPI.Validators
{
    public static class ValidatorsExtensions
	{
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
                .AddFluentValidationClientsideAdapters()
                .AddFluentValidationAutoValidation();

            return services;
        }
    }
}
