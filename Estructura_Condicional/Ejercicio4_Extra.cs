using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    public class Ejercicio4_Extra
    {
        public void calcular()
        {
            //La empresa “Te llevo a todos lados” está destinada al alquiler de autos y tiene un sistema
            //de tarifa que consiste en cobrar el alquiler por hora. Si el cliente devuelve el auto dentro
            //de las 2 horas de uso el valor que corresponde pagar es de $400 pesos y la nafta va de
            //regalo.Cuando el cliente regresa a la empresa pasadas las 2 horas, se ingresan la
            //cantidad de litros de nafta gastados y el tiempo transcurrido en horas.Luego, se le cobra
            //40 pesos por litro de nafta gastado, y la hora se fracciona en minutos, cobrando un total
            //de $5,20 el minuto de uso. Realice un programa que permita registrar esa información y el
            //total a pagar por el cliente

           
            float pagoAlquiler;
            byte numeroHorasAlquiler;
            byte cantidadLitrosNaftaGastados;
            float pagoPorLitroDeNaftaGastados;
            byte horasEnMinutos;
            float pagoPorMinuto;

            pagoAlquiler = 0;
            pagoPorLitroDeNaftaGastados = 0;
            horasEnMinutos = 0;
            pagoPorMinuto = 0;

            Console.WriteLine("Ingrese la Cantidad de Horas que uso el Vehiculo");
            numeroHorasAlquiler = byte.Parse(Console.ReadLine());

            if (numeroHorasAlquiler>0 && numeroHorasAlquiler<=2)
            {
                pagoAlquiler = numeroHorasAlquiler*200;
                Console.WriteLine("El Nafta va de regalo");

            }
            else
            {
                Console.WriteLine("Usted, excedió las 2 horas");
                Console.WriteLine("Ingrese la Cantidad de Litros de Nafta que ha utilizado");
                cantidadLitrosNaftaGastados = byte.Parse(Console.ReadLine());
                pagoPorLitroDeNaftaGastados = cantidadLitrosNaftaGastados * 40;
                horasEnMinutos = (byte)(numeroHorasAlquiler * 60);
                pagoPorMinuto =(float)(horasEnMinutos * 5.20);
                pagoAlquiler = numeroHorasAlquiler * 200;
                pagoAlquiler = pagoAlquiler + pagoPorLitroDeNaftaGastados + pagoPorMinuto;

            }
            Console.WriteLine("El Cliente pagará: s/." + pagoAlquiler);
            Console.ReadKey();
        }

    }
}
