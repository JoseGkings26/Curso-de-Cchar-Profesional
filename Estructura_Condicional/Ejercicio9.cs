using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio9
    {
        public void operacionesMatematicas()
        {
            //Construir un programa que simule un menú de opciones para realizar las cuatro
            //operaciones aritméticas básicas(suma, resta, multiplicación y división) con dos valores
            //numéricos enteros.El usuario, además, debe especificar la operación con el primer
            //carácter de la operación que desea realizar: ‘S' o ‘s’ para la suma, ‘R’ o ‘r’ para la resta, ‘M’ 
            //o ‘m’ para la multiplicación y ‘D’ o ‘d’ para la división.

            float num1, num2,resultado;
            resultado = 0;
            char operacion;
            Console.WriteLine("--------------------------------------------MENÚ DE OPCIONES--------------------------------------------");
            Console.WriteLine("Seleccione algúna de las Operaciones: Suma(S ó s) - Resta(R ó r) - Multiplicación(M ó m) - División(D o d)");
            operacion = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Primer Número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segundo Número: ");
            num2 = float.Parse(Console.ReadLine());


            switch (operacion){
                case 'S':
                case 's':
                    {
                        resultado = num1 + num2;
                        break;
                    }
                case 'R':
                case 'r':
                    {
                        resultado = num1 - num2;
                        break;
                    }
                case 'M':
                case 'm':
                    {
                        resultado = num1 * num2;
                        break;
                    }
                case 'D':
                case 'd':
                    {
                        resultado = num1 / num2;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operación no válida");
                        break;
                    }
            }

            Console.WriteLine("El Resultado es: " + resultado);
            Console.ReadKey();

        }
    }
}
