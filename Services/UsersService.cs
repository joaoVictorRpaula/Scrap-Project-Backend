using AutoMapper;
using SCRAP_API.Data;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCRAP_API.Services
{
    public class UsersService
    {
        private readonly IMapper _map;
        private readonly AppDbContext _db;

        public UsersService(IMapper map, AppDbContext db)
        {
            _map = map;
            _db = db;
        }


        public List<ReadUsersDto> GetUsers()
        {
            List<Users> users = _db.Users.ToList();

            List<ReadUsersDto> usersDtoList = _map.Map<List<ReadUsersDto>>(users);
            return usersDtoList;
        }

        public ReadUsersDto GetUsersById(int id)
        {
            Users user = _db.Users.FirstOrDefault(u => u.Id == id);
            if(user == null)
            {
                return null;
            }
            ReadUsersDto userDto = _map.Map<ReadUsersDto>(user);
            return userDto;
        }

        public ReadUsersDto GetUsersByEdv(string edv)
        {
            Users user = _db.Users.FirstOrDefault(u => u.Edv == edv);
            if (user == null)
            {
                return null;
            }
            ReadUsersDto usersDto = _map.Map<ReadUsersDto>(user);
            return usersDto;

        }
    }
}
