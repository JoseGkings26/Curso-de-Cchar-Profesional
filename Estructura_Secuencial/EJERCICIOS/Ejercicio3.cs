using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Secuencial.EJERCICIOS
{
    internal class Ejercicio3
    {
        public void convertidorLongitudes()
        {
            /* A partir de una conocida longitud de metros que el usuario ingresa a través del teclado se
            debe obtener su equivalente en centímetros, en milímetros y en pulgadas.
            Ayuda: 1 pulgada equivale a 2.54 centímetros.*/
            float metros, centimetros, milimetros, pulgadas;
            Console.WriteLine("Ingrse la Longitud en Metros: ");
            metros = float.Parse(Console.ReadLine());

            //PROCESO
            centimetros = metros * 100;
            milimetros =  metros * 1000;
            pulgadas = (float)(centimetros / 2.54);

            //SALIDA
            Console.WriteLine(metros + " metros en centimetros es: " + centimetros);
            Console.WriteLine(metros + " metros en milimetros es: " + milimetros);
            Console.WriteLine(metros + " metros en pulgadas es: " + pulgadas);
            Console.ReadKey();
        }
    }
}
