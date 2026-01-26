using Microsoft.AspNetCore.Mvc;
using ProyectoGenOmint.Models;
using ProyectoGenOmint.Services.Interface;

namespace ProyectoGenOmint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUserRandomService _UserRandomService;

        public UserController(ILogger<UserController> logger, IUserRandomService UserRandomService)
        {
            _logger = logger;
            _UserRandomService = UserRandomService;}
    [HttpGet]
    [Route("Random")]
    public User Test()
        {
            return _UserRandomService.GenerarUsuarioRandom();
        }
    
    }
  
}

