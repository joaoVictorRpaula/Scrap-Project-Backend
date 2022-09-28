using Microsoft.AspNetCore.Mvc;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Services;
using System.Collections.Generic;

namespace SCRAP_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class MachinesController : Controller
    {
        private readonly MachinesService _service;

        public MachinesController(MachinesService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllMachines()
        {
            List<ReadMachinesDto> machinesDto = _service.GetAllMachines();
            return Ok(machinesDto);
        }

        [HttpGet("Operation/{operationId}")]
        public IActionResult GetAllMachinesFromOperation(int operationId)
        {
            List<ReadMachinesDto> machinesDto = _service.GetAllMachinesFromOperation(operationId);

            if(machinesDto == null)
            {
                return NotFound();
            }

            return Ok(machinesDto);
        }
    }
}
