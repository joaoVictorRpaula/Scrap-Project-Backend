using AutoMapper;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;

namespace SCRAP_API.Profiles
{
    public class OperationsProfile : Profile
    {
        public OperationsProfile()
        {
            CreateMap<ReadOperationsDto, Operations>();
            CreateMap<Operations, ReadOperationsDto>();
        }
    }
}
