using AutoMapper;
using SCRAP_API.Data;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCRAP_API.Services
{
    public class MachinesService
    {
        private readonly IMapper _map;
        private readonly AppDbContext _db;

        public MachinesService(IMapper map, AppDbContext db)
        {
            _map = map;
            _db = db;
        }

        public List<ReadMachinesDto> GetAllMachines()
        {
            List<Machines> machines = _db.Machines.ToList();
            List<ReadMachinesDto> machinesDto = _map.Map<List<ReadMachinesDto>>(machines);
            return machinesDto;
        }

        public List<ReadMachinesDto> GetAllMachinesFromOperation(int operationId)
        {
            List<Machines> machines = _db.Machines.Where(m => m.OperationId == operationId).ToList();
            List<ReadMachinesDto> machinesDto = _map.Map<List<ReadMachinesDto>>(machines);

            return machinesDto;
        }

    }
}
