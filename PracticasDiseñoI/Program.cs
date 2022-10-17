using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasDiseñoI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practica1();
            //Practica2();
            Practica3();         

        }
        #region Practica 1
        static void Practica1()
        {
            //Área del círculo
                Console.WriteLine("Por favor, añade el radio del circulo");
                int radio_circulo = int.Parse(Console.ReadLine());
                double area = Math.Pow(radio_circulo, 2) * Math.PI;
                Console.WriteLine($"El área del circulo de radio {radio_circulo} es: {area}");
        }
        #endregion
        #region Practica 2
        static void Practica2()
        {
            const int PUEDE_CONDUCIR = 18;
            const string TIENE_CARNET = "S";

            Console.WriteLine("Vamos a evaluar si puedes conducir");
            Console.WriteLine("Introduce tu edad por favor:");
            int edad = Int32.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("¿Tienes carnet?(S/N)");
            string carnet = Console.ReadLine().ToUpper();
            
            if ((edad >= PUEDE_CONDUCIR))
            {
                Console.WriteLine("Puedes conducir");
            }
            else if(String.Equals(carnet, TIENE_CARNET))
            {
                Console.WriteLine("No puedes conducir");
            }
            else
            {
                Console.WriteLine("No puedes conducir");
            }
        }
        #endregion
        #region Practica 3
        static void Practica3()
        {
            String respuesta;

            do
            {
                Console.WriteLine("Quieres entrar al bucle?: (S/N)");
                respuesta = Console.ReadLine().ToUpper();

                if (respuesta.Equals("S"))
                {
                    Console.WriteLine("Bienvenido al bucle");
                }
                else if (respuesta.Equals("N"))
                {
                    Console.WriteLine("Has salido del bucle");
                }
                else
                {
                    Console.WriteLine("Debe introducir 'S' o 'N'");
                }
            } while (!respuesta.Equals("S") && !respuesta.Equals("N"));
        }
        #endregion
    }
}
