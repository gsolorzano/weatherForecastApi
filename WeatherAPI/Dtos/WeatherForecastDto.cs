using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WeatherAPI.Dtos
{
    /// <summary>
    /// WeatherForecastDto class.
    /// </summary>
    public class WeatherForecastDto
    {
        /// <summary>
        /// Gets or Sets the Id.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets the Date.
        /// </summary>
        [BsonElement("Date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets the TemperatureC.
        /// </summary>
        [BsonElement("TemperatureC")]
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets or Sets the Summary.
        /// </summary>
        [BsonElement("Summary")]
        public string Summary { get; set; }
    }
}
