using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Secuencial.EJERCICIOS
{
    internal class Ejercicio5
    {
        public void intercambioNumeros()
        {
            //Escriba un programa que permita al usuario ingresar el valor de dos variables numéricas de
            //tipo entero.Posteriormente, el programa debe intercambiar los valores de ambas variables y
            //mostrar el resultado final por pantalla.
            //Por ejemplo, si el usuario ingresa los valores num1 = 9 y num2 = 3, la salida a del programa
            //deberá mostrar: num1 = 3 y num2 = 9

            byte num1, num2,auxiliar;
            Console.WriteLine("Ingrese el Valor para el Num1: ");
            num1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Valor para el Num2: ");
            num2 = byte.Parse(Console.ReadLine());
            //PROCESO
            auxiliar = num2;
            num2 = num1;
            num1 = auxiliar;
            Console.WriteLine("El Nuevo Valor del Num1 es: " + num1);
            Console.WriteLine("El Nuevo Valor del Num2 es: " + num2);
            Console.ReadKey();
        }
    }
}
