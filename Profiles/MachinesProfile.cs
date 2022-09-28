using AutoMapper;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;

namespace SCRAP_API.Profiles
{
    public class MachinesProfile : Profile
    {
        public MachinesProfile()
        {
            CreateMap<ReadMachinesDto, Machines>();
            CreateMap<Machines, ReadMachinesDto>();
        }
    }
}
