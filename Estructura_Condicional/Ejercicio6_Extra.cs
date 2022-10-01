using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Ejercicio6_Extra
    {
        public void isValidDate()
        {
            //Leer tres números que denoten una fecha(día, mes, año) y comprobar que sea una fecha
            //válida.Si la fecha no es válida escribir un mensaje de error por pantalla.Si la fecha es
            //válida se debe imprimir la fecha cambiando el número que representa el mes por su
            //nombre.Por ejemplo: si se introduce 1 2 2006, se deberá imprimir “1 de febrero de 2006”. 
            int dia, mes, anio;
            int diasMes;
            string MesEnLetra = "";
           
            Console.WriteLine("Ingrese una Fecha: ");
            Console.WriteLine("Ingrese el día: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Año: ");
            anio = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:{
                        diasMes = 31;
                        MesEnLetra = "Enero";
                        if (dia>0 && dia<=diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                break;
                }
                case 2:{
                        MesEnLetra = "Febrero";
                        if (anio%4==0 && (anio%100!=0 || anio%400==0)) //Validamos si el año es Bisiesto
                        {
                            diasMes = 29;
                            if (dia > 0 && dia <= diasMes)
                            {
                                Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                            }
                            else
                            {
                                Console.WriteLine("La Fecha no es válida");
                            }
                        }
                        else
                        {
                            diasMes = 28;
                            if (dia > 0 && dia <= diasMes)
                            {
                                Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                            }
                            else
                            {
                                Console.WriteLine("La Fecha no es válida");
                            }
                        }
                        break;
                }
                case 3:{
                        diasMes = 31;
                        MesEnLetra = "Marzo";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 4:{
                        diasMes = 30;
                        MesEnLetra = "Abril";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 5:{
                        diasMes = 31;
                        MesEnLetra = "Mayo";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 6:{
                        diasMes = 30;
                        MesEnLetra = "Junio";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 7:{
                        diasMes = 31;
                        MesEnLetra = "Julio";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 8:{
                        diasMes = 31;
                        MesEnLetra = "Agosto";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 9:{
                        diasMes = 30;
                        MesEnLetra = "Septiemnbre";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 10:{
                        diasMes = 31;
                        MesEnLetra = "Octubre";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 11:{
                        diasMes = 30;
                        MesEnLetra = "Noviembre";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
                case 12:{
                        diasMes = 31;
                        MesEnLetra = "Diciembre";
                        if (dia > 0 && dia <= diasMes)
                        {
                            Console.WriteLine(dia + " de " + MesEnLetra + " de " + anio);
                        }
                        else
                        {
                            Console.WriteLine("La Fecha no es válida");
                        }
                        break;
                }
            }
            Console.ReadKey();
            
        }
    }
}
