using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio1
    {
        public void calcularSueldo()
        {
            /*  Un hombre desea saber si su sueldo es mayor al sueldo mínimo, el programa le pedirá al
            usuario su sueldo actual y el sueldo mínimo. Si el sueldo es mayor al mínimo se debe
            mostrar un mensaje por pantalla indicándolo.
            POR FAVOR USAR LA ESTRUCTURA DE CONDICION DE SIMPLE
            */

            float sueldoActual,sueldoMinimo;
            sueldoMinimo = 1050;
            Console.WriteLine("Ingrese su Sueldo Actual: ");
            sueldoActual = float.Parse(Console.ReadLine());
            if (sueldoActual>sueldoMinimo)
            {
                Console.WriteLine("El Sueldo Actual es Mayor al Sueldo Mínimo");
            }
            Console.ReadKey();
        }
    }
}
