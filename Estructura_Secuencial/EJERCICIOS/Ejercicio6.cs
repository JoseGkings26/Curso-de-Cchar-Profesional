using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Secuencial.EJERCICIOS
{
    internal class Ejercicio6
    {
        /*
         * Crear un programa que solicite al usuario que ingrese el precio de un producto al inicio del 
         año, y el precio del mismo producto al finalizar el año. El programa debe calcular cuál fue el 
        porcentaje de aumento que tuvo ese producto en el año y mostrarlo por pantalla.
         */
        public void calcularPorcentajeAumento()
        {
            //ENTRADA
            float precioProductoInAnio, precioProductoFinAnio;
            float porcentajeAumento, aumento;
            Console.WriteLine("Ingrese el Precio del Producto al Inicio del Año: ");
            precioProductoInAnio = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Precio del Producto al Fin del Año: ");
            precioProductoFinAnio = float.Parse(Console.ReadLine());
            //PROCESO
            aumento = precioProductoFinAnio - precioProductoInAnio;
            porcentajeAumento = (aumento * 100) / precioProductoInAnio;
            //SALIDA
            Console.WriteLine("El Aumento es: " + aumento);
            Console.WriteLine("El Porcentaje es: " + porcentajeAumento + "%");
            Console.ReadKey();
        }
    }
}
