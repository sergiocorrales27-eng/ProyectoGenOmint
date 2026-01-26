using ProyectoGenOmint.Services.Interface;

namespace ProyectoGenOmint.Models


{
    public class PersonaRandomService : IPersonaRandomService
    {
        private static Random random = new Random();

        public Persona GenerarPersonaRandom()
        {
            string genero = GenerarGeneroRandom();

            string nombreCompleto = GenerarNombreCompletoRandom(genero);

            return new Persona
            {
                NombreCompleto = nombreCompleto,
                Genero = genero,
                Dni = GenerarDniRandom(),
                FechaDeNacimiento = GenerarFechaNacimientoRandom(),
                Nacionalidad = GenerarNacionalidadRandom(),
                Profesion = GenerarProfesionRandom()
            };
        }

        private string GenerarNombreCompletoRandom(string genero)
        {
            string[] nombres = { "Tomas", "Franco", "Juan", "Lucas", "Martin", "Milagros", "Anna", "Lucia", "Sofia", "Camila" };
            string[] apellidos = { "Gomez", "Perez", "Rodriguez", "Fernandez", "Lopez" };

            string nombre = nombres[random.Next(nombres.Length)];

            string apellido = apellidos[random.Next(apellidos.Length)];

            return $"{nombre} {apellido}";
        }

        private string GenerarGeneroRandom()
        {
            string[] generos = { "Masculino", "Femenino" };
            return generos[random.Next(generos.Length)];
        }

        private int GenerarDniRandom()
        {
            return random.Next(10_000_000, 46_000_000);
        }

        private DateTime GenerarFechaNacimientoRandom()
        {
            int edad = random.Next(18, 85);
            return DateTime.Today.AddYears(-edad).AddDays(random.Next(365));
        }

        private string GenerarNacionalidadRandom()
        {
            string[] nacionalidades = { "Argentina", "Uruguaya", "Chilena", "Paraguaya", "yankee", "brazuca" };
            return nacionalidades[random.Next(nacionalidades.Length)];
        }

        private string GenerarProfesionRandom()
        {
            string[] profesiones = { "Ingeniero", "Docente", "Programador", "Medico", "Contador", "estudiante" };
            return profesiones[random.Next(profesiones.Length)];
        }
    }
}
