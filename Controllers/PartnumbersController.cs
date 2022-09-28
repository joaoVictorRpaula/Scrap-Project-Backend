using Microsoft.AspNetCore.Mvc;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Services;
using System.Collections.Generic;

namespace SCRAP_API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PartnumbersController : ControllerBase
    {
        private readonly PartnumbersService _service;

        public PartnumbersController(PartnumbersService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetPartnumbers()
        {
            List<ReadPartnumbersDto> readDtoList =  _service.GetPartnumbers();
            return Ok(readDtoList);
        }
        [HttpGet("{id}")]
        public IActionResult GetPartnumbersById(int id)
        {
            ReadPartnumbersDto readDto = _service.GetPartnumberById(id);
            return Ok(readDto);
        }

        [HttpGet("Produto/{productId}")]
        public IActionResult GetAllPartnumbersFromProduct(int productId)
        {
            List<ReadPartnumbersDto> readDtoList = _service.GetAllPartnumbersFromProduct(productId);
            if (readDtoList == null)
            {
                return NotFound();
            }
            return Ok(readDtoList);
        }
    }
}
