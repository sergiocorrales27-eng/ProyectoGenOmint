
using Microsoft.AspNetCore.Mvc;
using ProyectoGenOmint.Models;
using ProyectoGenOmint.Services.Interface;

namespace ProyectoGenOmint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            bool loginOk = _loginService.Login(request);

            if (!loginOk)
                return Unauthorized("Usuario o contraseña incorrectos");

            return Ok("Login exitoso");
        }
    }
}
