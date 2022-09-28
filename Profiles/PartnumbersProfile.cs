using AutoMapper;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;

namespace SCRAP_API.Profiles
{
    public class PartnumbersProfile : Profile
    {
        public PartnumbersProfile()
        {
            CreateMap<ReadPartnumbersDto, Partnumbers>();
            CreateMap<Partnumbers, ReadPartnumbersDto>();
        }
    }
}
