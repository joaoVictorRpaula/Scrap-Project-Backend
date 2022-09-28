using AutoMapper;
using SCRAP_API.Data;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCRAP_API.Services
{
    public class PartnumbersService
    {
        private readonly IMapper _map;
        private readonly AppDbContext _db;

        public PartnumbersService(IMapper map, AppDbContext db)
        {
            _map = map;
            _db = db;
        }

        public List<ReadPartnumbersDto> GetPartnumbers()
        {
            List<Partnumbers> partnumbers = _db.Partnumbers.ToList();
            if(partnumbers == null)
            {
                return null;
            }
            List<ReadPartnumbersDto> readDto = _map.Map<List<ReadPartnumbersDto>>(partnumbers);

            return readDto;
        }

        public ReadPartnumbersDto GetPartnumberById(int id)
        {
            Partnumbers partnumber = _db.Partnumbers.FirstOrDefault(p => p.IdPartnumber == id);

            if(partnumber == null)
            {
                return null;
            }

            ReadPartnumbersDto readDto = _map.Map<ReadPartnumbersDto>(partnumber);

            return readDto;
        }

        public List<ReadPartnumbersDto> GetAllPartnumbersFromProduct(int productId)
        {
            List<Partnumbers> partnumbers = _db.Partnumbers.Where(p => p.ProdutoId == productId).ToList();
            if (partnumbers == null)
            {
                return null;
            }
            List<ReadPartnumbersDto> readDtoList = _map.Map<List<ReadPartnumbersDto>>(partnumbers);

            return readDtoList;
        }
    }
}
