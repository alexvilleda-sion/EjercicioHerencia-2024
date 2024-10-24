using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Calculos
            Calculos calculos = new Calculos();

            // Llamar al método Imprimir para mostrar los resultados
            calculos.Imprimir();

            // Evitar que la consola se cierre inmediatamente
            Console.ReadKey();
        }
    }
}
