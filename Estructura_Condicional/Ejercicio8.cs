using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio8
    {
        public void validarLetra()
        {
            //Continuando el ejercicio anterior, ahora se pedirá una frase o palabra y se validara si la
            //primera letra de la frase es igual a la última letra de la frase.Se deberá de imprimir un
            //mensaje por pantalla que diga “CORRECTO”, en caso contrario, se deberá imprimir
            //“INCORRECTO”.

            string frase,primeraLetra,ultimaLetra;
            Console.WriteLine("Ingrese una Frase: ");
            frase = Console.ReadLine();
            primeraLetra = frase.Substring(0, 1); //Obtenemos la Primera letra
            ultimaLetra = frase.Substring(frase.Length-1,1); //Obtenemos la Última letra
            if (primeraLetra.ToUpper().Equals(ultimaLetra.ToUpper()))
            {
                Console.WriteLine("CORRECTO");
            }
            else
            {
                Console.WriteLine("INCORRECTO");
            }
            Console.ReadKey();
        }
    }
}
