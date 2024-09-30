using Microsoft.AspNetCore.Mvc;
using Tarefa3.Domain.Interfaces.Service;

namespace Tarefa3.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_personService.GetAll());
        }

    }
}
