using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio6
    {
        public void validarNumeros()
        {
            /*
            Escriba un programa que pida 3 notas y valide si esas notas están entre 1 y 10.Si están
            entre esos parámetros se debe poner en verdadero una variable de tipo lógico y si no
            ponerla en falso. Al final el programa debe decir si las 3 notas son correctas usando la
            variable de tipo lógico.
            */
            int nota1, nota2, nota3;
            bool notasValidas;
            Console.WriteLine("Ingrese Primera Nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Segunda Nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Tercera Nota: ");
            nota3 = int.Parse(Console.ReadLine());

            //VALIDAR QUE LAS NOTAS ESTEN ENTRE 1 Y 10
            if ((nota1>=1 && nota1<=10) && (nota2>=1 && nota2<=10) && (nota3>=1 && nota3<=10))
            {
                notasValidas = true;
            }
            else
            {
                notasValidas = false;
            }
            //VALIDAR QUE LAS NOTAS SEAN CORRECTAS
            if (notasValidas)
            {
                Console.WriteLine("LAS  NOTAS SON CORRECTAS");
            }
            else
            {
                Console.WriteLine("LAS  NOTAS SON INCORRECTAS");
            }
            Console.ReadKey();
        }
    }
}
