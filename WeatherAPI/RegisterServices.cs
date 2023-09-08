using System;
using WeatherAPI.Models;
using WeatherAPI.Models.Interfaces;
using WeatherAPI.Services;
using WeatherAPI.Services.Interfaces;

namespace WeatherAPI
{
    /// <summary>
    /// RegisterServices class.
    /// </summary>
    public static class RegisterServices
    {
        /// <summary>
        /// Adds the required services to the IServiceCollection.
        /// </summary>
        /// <param name="services">The IServiceCollection to modify.</param>
        /// <returns>The IServiceCollection.</returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Models
            services.AddScoped<IWeatherForecastModel, WeatherForecastModel>();

            // Services
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();

            return services;
        }
    }
}
