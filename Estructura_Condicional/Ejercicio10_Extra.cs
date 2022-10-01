using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio10_Extra
    {
        public void calcularPago()
        {
            /*
            Una verdulería ofrece las manzanas con descuento según la siguiente tabla:
            Nº DE KILOS COMPRADOS % DESCUENTO
                0 – 2
                2.01 – 5
                5.01 – 10
                10.01 en adelante
                0 %
                10 %
                15 %
                20 %
           Determinar cuánto pagará una persona que compre manzanas en esa verdulerí
            */
            double numeroKilosComprados, precioPorKilo, importeCompra, importeFinal;
            double descuento;
            importeFinal = 0;
            importeCompra = 0;
            precioPorKilo = 0;
            numeroKilosComprados = 0;

            Console.WriteLine("Cuántos Kilos compró: ");
            numeroKilosComprados = float.Parse(Console.ReadLine());
            Console.WriteLine("Cuánto le costo el Kilo de Manzana");
            precioPorKilo = double.Parse(Console.ReadLine());


            if (numeroKilosComprados>=0 && numeroKilosComprados<=2)
            {
                importeCompra = numeroKilosComprados * precioPorKilo;
                descuento = 0;
                importeFinal = importeCompra - ((importeCompra * descuento));

            }
            else if (numeroKilosComprados >= 2.1 && numeroKilosComprados <= 5)
            {
                importeCompra = numeroKilosComprados * precioPorKilo;
                descuento = 0.1;
                importeFinal = importeCompra - ((importeCompra * descuento));

            }
            else if (numeroKilosComprados >= 5.01 && numeroKilosComprados <= 10)
            {
                importeCompra = numeroKilosComprados * precioPorKilo;
                descuento = 0.15;
                importeFinal = importeCompra - ((importeCompra * descuento));
            }
            else if (numeroKilosComprados >=10)
            {
                importeCompra = numeroKilosComprados * precioPorKilo;
                descuento = 0.20;
                importeFinal = importeCompra - ((importeCompra * descuento));
            }

            Console.WriteLine("El Importe Final que pagaras es: " + importeFinal);
            Console.ReadKey();
        }
    }
}
