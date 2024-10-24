using System;

namespace EjercicioHerencia
{
    // Clase padre
    public class Operaciones
    {
        // Método para calcular el área de un rectángulo
        public double CalcularAreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }

        // Método para calcular la circunferencia de un círculo
        public double CalcularCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }

        // Método para calcular el volumen de un cubo
        public double CalcularVolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }
    }
}
