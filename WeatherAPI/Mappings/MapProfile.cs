using AutoMapper;
using MongoDB.Bson;
using WeatherAPI.Dtos;

namespace WeatherAPI.Mappings
{
    /// <summary>
    /// MapProfile class.
    /// </summary>
    public class MapProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapProfile"/> class.
        /// </summary>
        public MapProfile()
        {
            CreateMap<CreateWeatherForecastDto, WeatherForecastDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => ObjectId.GenerateNewId().ToString()));
        }
    }
}
