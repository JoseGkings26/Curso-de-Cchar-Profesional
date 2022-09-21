using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Secuencial.EJERCICIOS
{
    internal class Ejercicio8
    {
        public void calculoRaices()
        {
            //ENTRADA
            float num,raizCuadrada,raizCubica,potenciaAlCuadrado,potenciaAlCubo;
            Console.WriteLine("Ingrese el Número: ");
            num = float.Parse(Console.ReadLine());
            //PROCESO
            raizCuadrada = (float)(Math.Pow(Convert.ToDouble(num), 1.0 / 2.0));
            raizCubica =(float)(Math.Pow(Convert.ToDouble(num),1.0 / 3.0));
            //RESULTADO
            Console.WriteLine("La Raiz Cuadrada del Número es: " + raizCuadrada);
            Console.WriteLine("La Potencia es: " + raizCubica);
            Console.ReadKey();
        }
    }
}
