using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Secuencial.EJERCICIOS
{
    internal class Ejercicio7
    {
        /*Calcular el cambio de monedas en dólares y euros al ingresar cierta cantidad de dinero en soles.
         1euro = s/5.00
         1dolar =s/4.00
        */
        
        public void conversorMonedas()
        {
            //ENTRADA
            float montoSoles, montoDolares, montoEuros,tarifaDolares,tarifaEuros;
            Console.WriteLine("Ingrese el Monto en Soles: ");
            montoSoles = float.Parse(Console.ReadLine());
            tarifaDolares =(float)(3.5);
            tarifaEuros = (float)(4.5);

            //PROCESO
            montoDolares = montoSoles / tarifaDolares;
            montoEuros = montoSoles / tarifaEuros;

            //SALIDA
            Console.WriteLine(montoSoles + " Soles en Dólares es: " + Math.Round((double)(montoDolares),1));
            Console.WriteLine(montoSoles + " Soles en Euros es: " + Math.Round((double)(montoEuros), 1));
            Console.ReadKey();
        }
       

    }
}
