namespace WeatherAPI.Dtos
{
    public class WeatherForecastDto
    {
        /// <summary>
        /// Gets or Sets the Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets the Temperature in Celcius
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets or Sets the weather summary
        /// </summary>
        public string Summary { get; set; }
    }
}

