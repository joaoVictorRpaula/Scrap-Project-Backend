using Microsoft.AspNetCore.Mvc;
using SCRAP_API.Data.Dtos;
using SCRAP_API.Services;
using System.Collections.Generic;

namespace SCRAP_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersService _service;
        public UsersController(UsersService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetUsers()
        {
            List<ReadUsersDto> usersDto = _service.GetUsers();

            if (usersDto == null)
            {
                return BadRequest();
            }

            return Ok(usersDto);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetUsersById(int id)
        {
            ReadUsersDto usersDto = _service.GetUsersById(id);

            if (usersDto == null)
            {
                return BadRequest();
            }

            return Ok(usersDto);
        }

        [HttpGet("edv")]
        public IActionResult GetUsersByEdv(string edv)
        {
            ReadUsersDto usersDto = _service.GetUsersByEdv(edv);
            if (usersDto == null)
            {
                return NotFound();
            }
            return Ok(usersDto);
        }
    }
}
