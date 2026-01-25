//implementacion del patron de inyeccion de dependencia

using Microsoft.AspNetCore.Mvc;
using ProyectoGenOmint.Controllers;
using ProyectoGenOmint.Services;

namespace ProyectoGenOmint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
    } }
