using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio4
    {
        public void mostrarMensaje()
        {
            /*
            Realizar un programa que pida introducir solo frases o palabras de 6 caracteres.Si el
            usuario ingresa una frase o palabra de 6 caracteres se deberá de imprimir un mensaje por
            pantalla que diga “CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”. 
            Nota: investigar la funcion length o size en c#.
            */
            string frase;
            byte longitudFrase;
            Console.WriteLine("Ingrese una Frase o Palabra de 6 caracteres: ");
            frase = Console.ReadLine();
            longitudFrase = (byte)frase.Length;
            if (longitudFrase==6)
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
