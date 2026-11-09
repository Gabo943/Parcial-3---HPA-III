using Newtonsoft.Json;

namespace Parcial_3___Parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paso 3: Crear objeto con datos
            var persona = new
            {
                Nombre = "Cristell",
                Edad = 20,
                Carrera = "Ingeniería en Sistemas"
            };

            // Paso 4: Convertir objeto a cadena JSON
            string json =
            JsonConvert.SerializeObject(persona);

            Console.WriteLine(json);
        }
    }
}
