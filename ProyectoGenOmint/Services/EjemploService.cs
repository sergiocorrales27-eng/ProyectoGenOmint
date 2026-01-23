using ProyectoGenOmint.Services.Interface;
using ProyectoGenOmint.Models;

namespace ProyectoGenOmint.Services
{
    //Clase que implementa la interfaz IEjemplo
    public class EjemploService : IEjemplo
    {
        public Ejemplo GetEjemplo()
        {
            return new Ejemplo
            {
                Id = 1,
                Nombre = "Ejemplo de servicio"
            };
        }
    }
}
