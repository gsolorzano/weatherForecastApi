using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WeatherAPI.Dtos
{
    public class WeatherForecastDto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Date")]
        public DateTime Date { get; set; }

        [BsonElement("TemperatureC")]
        public int TemperatureC { get; set; }

        [BsonElement("Summary")]
        public string Summary { get; set; }
    }
}
