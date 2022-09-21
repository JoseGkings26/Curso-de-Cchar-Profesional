using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    public class Ejercicio7_extra
    {
        public void determinarNumeroTresDigitos()
        {
            //   Hacer un algoritmo que lea un número por el teclado y determine si tiene tres dígito
            int num;
            Console.WriteLine("Ingrese un Número: ");
            num = int.Parse(Console.ReadLine());
            
            if (num>=100 && num<=999)
            {
                Console.WriteLine("Tiene 3 dígitos");
            }
            else
            {
                Console.WriteLine("No tiene 3 dígitos");
            }
            Console.ReadKey();
        }
    }
}
