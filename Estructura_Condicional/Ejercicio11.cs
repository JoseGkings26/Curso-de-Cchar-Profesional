using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio11
    {
        public void obtenerGradoEficiencia()
        {
            //  . Escriba un programa para obtener el grado de eficiencia de un operario de una fábrica de
            //  tornillos, de acuerdo a las siguientes dos condiciones que se le imponen para un período
            //  de prueba:
            //• Producir menos de 200 tornillos defectuosos.
            //• Producir más de 10000 tornillos sin defectos.
            //• El grado de eficiencia se determina de la siguiente manera:
            //• Si no cumple ninguna de las condiciones, grado 5.
            //• Si sólo cumple la primera condición, grado 6.
            //• Si sólo cumple la segunda condición, grado 7.
            //• Si cumple las dos condiciones, grado 8
            //  Nota: para trabajar este ejercicio de manera prolija, ir probando cada inciso que pide el
            //  ejercicio.No hacer todos al mismo tiempo y después probar
            int cantidadTornillosDefectuosos, cantidadTorinillosSinDefectos;
            int gradoEficiencia;
            Console.WriteLine("Ingrese la cantidad de Tornillos defectuosos: ");
            cantidadTornillosDefectuosos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de Tornillos sin Defectos: ");
            cantidadTorinillosSinDefectos = int.Parse(Console.ReadLine());

            if (cantidadTornillosDefectuosos < 200)
            {
                if (cantidadTorinillosSinDefectos > 10000)
                {
                    gradoEficiencia = 8; //Aquí cumple las 2 condiciones
                }
                else
                {
                    gradoEficiencia = 6;//Aqui solo cumple la primera condición
                }
            }
            else
            {
                if (cantidadTorinillosSinDefectos > 10000)
                {
                    gradoEficiencia = 7;  //Aquí no cumple la primera condición pero si cumple la segunda condición
                }
                else
                {
                    gradoEficiencia = 5;
                }
            }
            Console.WriteLine("El Grado de Eficiencia es: " + gradoEficiencia);
            Console.ReadKey();
        }
    }
}
