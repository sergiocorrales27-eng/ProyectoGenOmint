//using Entidades;
using System;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private static Random random = new Random();

        //public Usuario GenerarUsuarioRandom()
        //{
        //    string[] nombresBase = { "Tomas", "Franco", "Juan", "Milagros", "Anna" };

        //    string nombreUsuario = nombresBase[random.Next(nombresBase.Length)]
        //                           + random.Next(100, 999);

        //    string contraseña = GenerarContraseñaRandom();

        //    int id = GenerarIdRandom();


        //    return new Usuario
        //    {
        //        NombreUsuario = nombreUsuario,
        //        Contraseña = contraseña,
        //        Id = id

        //    };
        //}

        //private string GenerarContraseñaRandom()
        //{
        //    const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        //    char[] password = new char[8];

        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        password[i] = caracteres[random.Next(caracteres.Length)];
        //    }

        //    return new string(password);
        //}
        //private int GenerarIdRandom()
        //{
        //    return random.Next(10_000_000, 99_000_000);
        //}
    }
}


