using Microsoft.AspNetCore.Mvc;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Services;
using System.Collections.Generic;

namespace SCRAP_API.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class OperationsController : Controller
    {
        private readonly OperationsService _service;

        public OperationsController(OperationsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetOperations()
        {
            List<ReadOperationsDto> Operations = _service.GetAllOperations();
            if(Operations == null)
            {
                return NotFound();
            }
            return Ok(Operations);
        }

    }
}
