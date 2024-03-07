using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                

                //if (i == 3)
                //{
                //    Console.WriteLine("A los 3 nos detenemos");
                //    break;
                //}

                if (i % 2 == 0)
                {
                    Console.WriteLine("El próximo es impar");
                    continue;
                }
                Console.WriteLine(i);

            }

            Console.Read();
        }
    }
}
