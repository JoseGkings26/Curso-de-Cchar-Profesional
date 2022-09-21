using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio2_Extra
    {
        public void calcularMontoTotal()
        {
            //Una tienda ofrece para los meses de septiembre, octubre y noviembre un descuento del
            //10 % sobre el total de la compra que realiza un cliente.Solicitar al usuario que ingrese un
            //mes y el importe de la compra.El programa debe calcular cuál es el monto total que se
            //debe cobrar al cliente e imprimirlo por pantalla.

            String mes=""; //Inicializacion de una variable tipo caracter
            float importeCompra = 0, descuento = 0, montoTotal = 0;
            Console.WriteLine("Ingrese un Mes: ");
            mes = Console.ReadLine();
            Console.WriteLine("Ingrese el Importe de la Compra");
            importeCompra = float.Parse(Console.ReadLine());

            switch (mes)
            {
                case "septiembre":
                case "Octubre":
                case "Noviembre":
                    descuento = (float)(0.1 * importeCompra);
                break;
                default:
                    {
                        descuento = 0;
                        break;
                    }
            }
            montoTotal = importeCompra - descuento;
            Console.WriteLine("El Monto totl es: "+montoTotal);
        }

    }
}
