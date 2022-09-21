using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio3
    {
        public void detarminarParImpar()
        {
            /*
                Realizar un programa que pida un número y determine si ese número es par o impar. 
                Mostrar en pantalla un mensaje que indique si el número es par o impar. (para que un 
                número sea par, se debe dividir entre dos y su resto debe ser igual a 0). Nota: investigar 
                la función residuo en C#
             double num1, num2, cociente, residuo;
            */
            //num1 = 10;
            //num2 = 3;
            //cociente = num1 / num2; //Esta división te devuelve el COCIENTE
            //residuo = num1 % num2; //Esta división te devuelve el RESIDUO
            //Console.WriteLine("El Cociente es: " + cociente);
            //Console.WriteLine("El Residuo es: " + residuo);
            //Console.ReadKey();

            float numero;
            Console.WriteLine("Ingrese un Número: ");
            numero = float.Parse(Console.ReadLine());

            if (numero%2==0)
            {
                Console.WriteLine("ES PAR");
            }
            else
            {
                Console.WriteLine("ES IMPAR");
            }
            Console.ReadKey();        
        }
    }
}
