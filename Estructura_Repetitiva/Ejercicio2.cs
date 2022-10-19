using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Repetitiva
{
    public class Ejercicio2
    {
        public void mostrarNumerosDelIntervalo()
        {
            /*Escriba un programa que solicite dos números enteros (mínimo y máximo). A continuación, 
            se debe pedir al usuario que ingrese números enteros situados entre el máximo y mínimo. 
            Cada vez que un número se encuentre entre ese intervalo, se sumara uno a una variable. 
            El programa terminará cuando se escriba un número que no pertenezca a ese intervalo, y 
            al finalizar se debe mostrar por pantalla la cantidad de números ingresados dentro del 
            intervalo.*/

            int min = 0,max = 0,num=0;
            int cont = 0;

            Console.WriteLine("Ingrese el valor mínimo del Intervalo: ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor máximo del Intervalo: ");
            max = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un Número: ");
            num = int.Parse(Console.ReadLine());

            while (num>=min && num<=max)
            {
                Console.WriteLine("Ingrese un Número: ");
                num = int.Parse(Console.ReadLine());
                cont++; //Cuento la cantidad de numeros que están dentro del intervalo
            }
            Console.WriteLine("La cantidad de Números que ingresados que pertenecen al intervalo es: " + cont);
            Console.ReadKey();
        }
    }
}
