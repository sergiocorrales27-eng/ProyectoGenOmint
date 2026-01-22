using Negocio;
using ProyectoGenOmint.Models;
using System;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            Usuario usuario = negocio.GenerarUsuarioRandom();

            Console.WriteLine("USUARIO GENERADO");
            Console.WriteLine("----------------");
            Console.WriteLine($"Usuario: {usuario.NombreUsuario}");
            Console.WriteLine($"Contraseña: {usuario.Contrasenia}");

            Console.ReadKey();
        }
    }
}
