using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio5
    {
        public void mostrarFraseFinal()
        {
            /*
             Realizar un programa que pida una frase o palabra y si la frase o palabra es de 4 
             caracteres de largo, el programa le concatenara un signo de exclamación al final, y si no 
             es de 4 caracteres el programa le concatenara un signo de interrogación al final. El 
             programa mostrará después la frase final. Nota: investigar la función Longitud() y 
             Concatenar() de PseInt
             */
            string frase;
            byte longitudFrase;
            Console.WriteLine("Ingrese frase o palabra: ");
            frase = Console.ReadLine();
            longitudFrase =(byte)frase.Length;
            if (longitudFrase == 4)
            {
                Console.WriteLine(frase + "!");
            }
            else
            {
                Console.WriteLine(frase + "?");
            }

            Console.ReadKey();
        }
    }
}
