using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Obtener todos los números impares del 0 al 20

            // Manera larga
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            for (int i = 1; i < 20; i+=2)
            {
                Console.WriteLine("{0} es impar", i);
            }


            Console.Read();
        }
    }
}
