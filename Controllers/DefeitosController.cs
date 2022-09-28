using Microsoft.AspNetCore.Mvc;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Services;
using System.Collections.Generic;

namespace SCRAP_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class DefeitosController : Controller
    {
        private readonly DefeitosService _service;

        public DefeitosController(DefeitosService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllDefeitos()
        {
            List<ReadDefeitosDto> defeitosDto = _service.GetAllDefeitos();
            return Ok(defeitosDto);
        }
    }
}
