using AutoMapper;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;

namespace SCRAP_API.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<ReadUsersDto, Users>();
            CreateMap<Users, ReadUsersDto>();

        }
    }
}
