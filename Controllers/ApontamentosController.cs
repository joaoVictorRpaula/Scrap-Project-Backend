using Microsoft.AspNetCore.Mvc;
using SCRAP_API.Services;
using SCRAP_API.Data.Dtos;

namespace SCRAP_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class ApontamentosController : Controller
    {
        private readonly ApontamentosService _service;

        public ApontamentosController(ApontamentosService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult AddApontamento(AddApontamentosDto apontamentosDto)
        {
            AddApontamentosDto apontamento = _service.AddApontamento(apontamentosDto);
            if (apontamento == null)
            {
                return NotFound();
            }
            return Ok(apontamento);
        }
    }
}
