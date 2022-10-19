using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Repetitiva
{
    public class Ejercicio1
    {
        public void validarSiNumEsMayorque10()
        {
            /*Escriba un programa en el cual se ingrese un número y mientras ese número sea mayor 
            de 10, se pedirá el número de nuevo*/

            int numero=0;
            Console.WriteLine("Ingrese un Número");
            numero = int.Parse(Console.ReadLine());
            while (numero>10)
            {
                Console.WriteLine("Ingrese un Número");
                numero = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
