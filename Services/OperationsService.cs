using AutoMapper;
using SCRAP_API.Data;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCRAP_API.Services
{
    public class OperationsService
    {
        private readonly IMapper _map;
        private readonly AppDbContext _db;
        public OperationsService(AppDbContext db, IMapper map)
        {
            _db = db;
            _map = map;
        }

        public List<ReadOperationsDto> GetAllOperations()
        {
            List<Operations> operationsList = _db.Operations.ToList();
            List<ReadOperationsDto> operationsDto = _map.Map<List<ReadOperationsDto>>(operationsList);

            return operationsDto;
        }

    }
}
