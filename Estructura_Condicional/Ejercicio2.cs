using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio2
    {
        public void mostrarMensajeCorrectoIncorrecto()
        {
            /*Realiza un programa que sólo permita introducir los caracteres ‘S’ y ‘N’. Si el usuario
            ingresa alguno de esos dos caracteres se deberá de imprimir un mensaje por pantalla que
            diga “CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”.*/

            char letra;

            Console.WriteLine("Ingrese un Caracter: ");
            letra = char.Parse( Console.ReadLine());

            if (letra=='S' || letra=='N')
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
