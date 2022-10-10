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
            //Área del círculo
            Console.WriteLine("Por favor, añade el radio del circulo");
            int radio_circulo = int.Parse(Console.ReadLine());
            double area = Math.Pow(radio_circulo, 2) * Math.PI;
            Console.WriteLine($"El área del circulo de radio {radio_circulo} es: {area}");
        }
    }
}
