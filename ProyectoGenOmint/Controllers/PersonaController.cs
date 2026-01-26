using Microsoft.AspNetCore.Mvc;
using ProyectoGenOmint.Models;
using ProyectoGenOmint.Services.Interface;

namespace ProyectoGenOmint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {

        private readonly ILogger<PersonaController> _logger;
        private readonly IPersonaRandomService _PersonaRandomService;

        public PersonaController(ILogger<PersonaController> logger, IPersonaRandomService PersonaRandomService)
        {
            _logger = logger;
            _PersonaRandomService = PersonaRandomService;
        }
        [HttpGet]
        [Route("Persona-test")]
        public Persona Test()
        {
            return _PersonaRandomService.GenerarPersonaRandom();
        }

    }

}