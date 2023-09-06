using WeatherAPI.Services.Interfaces;

namespace WeatherAPI.Services
{
	public static class ServicesExtensions
	{
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();

            return services;
        }
    }
}

