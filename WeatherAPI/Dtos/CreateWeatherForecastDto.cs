using MongoDB.Bson.Serialization.Attributes;

namespace WeatherAPI.Dtos
{
    public class CreateWeatherForecastDto
    {
        [BsonElement("Date")]
        public DateTime Date { get; set; }

        [BsonElement("TemperatureC")]
        public int TemperatureC { get; set; }

        [BsonElement("Summary")]
        public string Summary { get; set; }
    }
}
