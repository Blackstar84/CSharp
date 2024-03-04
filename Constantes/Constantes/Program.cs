using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    internal class Program
    {
        const double PI = 3.14159265359;
        const int semanas = 52, meses = 12;
        const string nacimiento = "14.08.1984";



        static void Main(string[] args)
        {
            Console.WriteLine("Mi nacimiento fue el: {0}", nacimiento);
            Console.Read();
        }
    }
}
