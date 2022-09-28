using AutoMapper;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;

namespace SCRAP_API.Profiles
{
    public class DefeitosProfile : Profile
    {
        public DefeitosProfile()
        {
            CreateMap<Defeitos, ReadDefeitosDto>();
            CreateMap<ReadDefeitosDto, Defeitos>();
        }
    }
}
