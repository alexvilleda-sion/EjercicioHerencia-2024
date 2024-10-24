using System;

namespace EjercicioHerencia
{
    // Clase hija que hereda de Operaciones
    public class Calculos : Operaciones
    {
        // Método para imprimir los resultados
        public void Imprimir()
        {
            // Ejemplo de valores
            double largo = 5;
            double ancho = 10;
            double radio = 3;
            double ladoCubo = 4;

            // Llamada a los métodos de la clase base
            double areaRectangulo = CalcularAreaRectangulo(largo, ancho);
            double circunferencia = CalcularCircunferencia(radio);
            double volumenCubo = CalcularVolumenCubo(ladoCubo);

            // Mostrar resultados
            Console.WriteLine("Área del Rectángulo: " + areaRectangulo);
            Console.WriteLine("Circunferencia del Círculo: " + circunferencia);
            Console.WriteLine("Volumen del Cubo: " + volumenCubo);
        }
    }
}
