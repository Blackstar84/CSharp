using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomar_Decisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int temperatura = 10;

            //if (temperatura < 10) 
            //{
            //    Console.WriteLine("Abrígate!");
            //}

            //if (temperatura == 10)
            //{
            //    Console.WriteLine("Hace 10 grados de temperatura!");
            //}

            //if (temperatura > 10)
            //{
            //    Console.WriteLine("Está cálido!");
            //}

            Console.WriteLine("Por Favor, ingresa la temperatura actual: ");

            string temperatura = Console.ReadLine();
            int numTemperatura = int.Parse(temperatura);


            if (numTemperatura < 20)
            {
                Console.WriteLine("Abrígate!");  
            }else if(numTemperatura == 20) 
            {
                Console.WriteLine("Vístete cómodo");
            }
            else
            {
                Console.WriteLine("Usa ropa bien liviana");
            }

            Console.Read();

        }
    }
}
