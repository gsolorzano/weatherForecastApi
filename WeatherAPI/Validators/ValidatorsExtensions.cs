using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace WeatherAPI.Validators
{
    /// <summary>
    /// ValidatorsExtensions class.
    /// </summary>
    public static class ValidatorsExtensions
    {
        /// <summary>
        /// Adds the validatos to the IServiceCollection.
        /// </summary>
        /// <param name="services">The IServiceCollection to modify.</param>
        /// <returns>The IServiceCollection.</returns>
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
                .AddFluentValidationClientsideAdapters()
                .AddFluentValidationAutoValidation();

            return services;
        }
    }
}
