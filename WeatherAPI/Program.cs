namespace WeatherAPI;

/// <summary>
/// Program class.
/// </summary>
public class Program
{
    /// <summary>
    /// The main class.
    /// </summary>
    /// <param name="args">The app args.</param>
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    /// <summary>
    /// Creates the HostBuilder.
    /// </summary>
    /// <param name="args">The app args.</param>
    /// <returns>The IHostBuilder.</returns>
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
