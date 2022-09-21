using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Secuencial.EJERCICIOS
{
    internal class Ejercicio1
    {
            public void calcularAreaPerimetro()
            {
            /*
            Conocido el número en matemática PI π, pedir al usuario que ingrese el valor del radio de
            una circunferencia y calcular y mostrar por pantalla el área y perímetro. Recuerde que para
            calcular el área y el perímetro se utilizan las siguientes fórmulas:
            area = PI * radio2
            perimetro = 2 * PI * radio*/

            //ENTRADA (DECLARACIÓN DE VARIABLES)
            float radio, area, perimetro;
            Console.WriteLine("Ingrese el Radio de la Circunferencia: ");
            radio = float.Parse(Console.ReadLine());

            //PROCESO
            area = (float)(Math.PI * Math.Pow(radio, 2));
            //area = (float)(Math.PI * (radio * radio));
            perimetro = (float)(2 * Math.PI * radio);

            //SALIDA
            Console.WriteLine("El Área de la Circunferencia es: " + area);
            Console.WriteLine("El Perimetro de la Circunferencia es: " + perimetro);
            Console.ReadKey();
        }    
    }
}
