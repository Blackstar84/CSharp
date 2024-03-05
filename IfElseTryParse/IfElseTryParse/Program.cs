using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por Favor, ingresa la temperatura actual");   

            string temperatura = Console.ReadLine();

            int numTemperatura;

            int numero;

            if(int.TryParse(temperatura, out numero))
            {
                numTemperatura = numero;
            }
            else
            {
                numTemperatura = 0;
                Console.WriteLine("El valor ingresado no es válido, se estableció que la temperatura es 0");
            }

            if (numTemperatura < 20)
            {
                Console.WriteLine("Abrígate!");
            }
            else if (numTemperatura == 20)
            {
                Console.WriteLine("Vístete Cómodo!");
            }
            else if (numTemperatura > 30)
            {
                Console.WriteLine("Hacen 30 grados, ¡qué calor!");
            }
            else
            {
                Console.WriteLine("Usa ropa bien liviana!");
            }

            Console.Read();
        }
    }
}
