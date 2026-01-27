using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoGenOmint.Models;
using ProyectoGenOmint.Services.Interface;

namespace ProyectoGenOmint.Services
{
    public class LoginService : ILoginService
    {
        private List<User> usuarios = new List<User>
        {
            new User
            {
                Id = 1,
                NombreUsuario = "admin",
                Contrasenia = "1234"
            },
            new User
            {
                Id = 2,
                NombreUsuario = "tomas",
                Contrasenia = "abcd"
            }
        };

        public bool Login(LoginRequest request)
        {
            return usuarios.Any(u =>
                u.NombreUsuario == request.NombreUsuario &&
                u.Contrasenia == request.Contrasenia);
        }
    }
}