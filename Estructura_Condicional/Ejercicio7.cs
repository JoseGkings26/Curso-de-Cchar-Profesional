using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio7
    {
        public void validarLetra()
        {
            /*
            Escriba un programa que pida una frase o palabra y valide si la primera letra de esa frase
            es una ‘A’. Si la primera letra es una ‘A’, se deberá de imprimir un mensaje por pantalla
            que diga “CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”. Nota:
            investigar la función Subcadena de PseInt
            */
            string frase,primeraLetra;
            Console.WriteLine("Ingrese una Frase: ");
            frase = Console.ReadLine();
            primeraLetra= frase.Substring(0, 1);

            //Console.WriteLine(primeraLetra);

            if (primeraLetra.ToLower().Equals("a"))
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
