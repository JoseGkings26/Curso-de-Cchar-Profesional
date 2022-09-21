using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Secuencial.EJERCICIOS
{
    internal class Ejercicio2
    {
        public  void calcularPromedio()
        {
            //Escribir un programa que calcule el precio promedio de un producto.El precio promedio se
            //debe calcular a partir del precio del mismo producto en tres establecimientos distintos.
            float precioA, precioB, precioC, promedioPrecios;
            Console.WriteLine("Ingrese el Precio del Producto X, del Establecimiento A");
            precioA = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Precio del Producto X, del Establecimiento B");
            precioB = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Precio del Producto X, del Establecimiento C");
            precioC = float.Parse(Console.ReadLine());

            //PROCESO
            promedioPrecios = (precioA + precioB + precioC) / 3;

            //SALIDA
            Console.WriteLine("El Promedio de los Precios del Producto X es: " + promedioPrecios);
            Console.ReadKey();
        }
        
    }
}
