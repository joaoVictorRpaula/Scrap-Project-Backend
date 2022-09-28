using AutoMapper;
using SCRAP_API.Data;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCRAP_API.Services
{
    public class DefeitosService
    {
        private readonly IMapper _map;
        private readonly AppDbContext _db;

        public DefeitosService(IMapper map, AppDbContext db)
        {
            _map = map;
            _db = db;
        }

        public List<ReadDefeitosDto> GetAllDefeitos()
        {
            List<Defeitos> defeitos = _db.Defeitos.ToList();
            List<ReadDefeitosDto> defeitosDto = _map.Map<List<ReadDefeitosDto>>(defeitos);

            return defeitosDto;
        }

    }
}
