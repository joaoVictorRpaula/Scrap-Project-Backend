using AutoMapper;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;

namespace SCRAP_API.Profiles
{
    public class ApontamentosProfile : Profile
    {
        public ApontamentosProfile()
        {
            CreateMap<AddApontamentosDto, Apontamentos>();
            CreateMap<Apontamentos, AddApontamentosDto>();
        }
    }
}
