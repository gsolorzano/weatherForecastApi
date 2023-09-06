
using WeatherAPI.Models.Interfaces;

namespace WeatherAPI.Models
{
	public static class ModelsExtensions
	{
        public static IServiceCollection AddModels(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastModel, WeatherForecastModel>();

            return services;
        }
    }
}

