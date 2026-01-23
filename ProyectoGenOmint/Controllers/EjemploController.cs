using Microsoft.AspNetCore.Mvc;
using ProyectoGenOmint.Models;
using ProyectoGenOmint.Services.Interface;

namespace ProyectoGenOmint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EjemploController : ControllerBase
    {
        //Interfaz del elemento a inyectar
        private readonly ILogger<EjemploController> _logger;
        private readonly IEjemplo _ejemplo;

        //Constructor donde se inyecta la dependencia
        public EjemploController(ILogger<EjemploController> logger, IEjemplo ejemplo)
        {
            _logger = logger;
            _ejemplo = ejemplo;
        }

        [HttpGet]
        [Route("GetEjemplo")]
        public Ejemplo GetEjemplo()
        {
            //Uso del servicio inyectado
            return _ejemplo.GetEjemplo();
        }
    }
}
