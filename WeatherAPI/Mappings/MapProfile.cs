using AutoMapper;
using MongoDB.Bson;
using WeatherAPI.Dtos;

namespace WeatherAPI.Mappings
{
	public class MapProfile : Profile
    {
		public MapProfile()
		{
            CreateMap<CreateWeatherForecastDto, WeatherForecastDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => ObjectId.GenerateNewId().ToString()));
        }
	}
}
