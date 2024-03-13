using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Arrays_Irregulares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] familiaJuan = new string[] { "Laura", "Juan" };


            string[][] amigosFamilia = new string[][]
            {
                new string[] {"Miguel", "Sandra" },
                new string[] {"Franco", "Claudia", "Oscar", "Leon" },
                new string[] {"Andrés", "Mónica", "Lucía" },
                familiaJuan
            };

            Console.WriteLine("Hola {0}, quiero presentarte a {1}", amigosFamilia[0][0], amigosFamilia[1][0]);
            Console.WriteLine("Hola {0}, quiero presentarte a {1}", amigosFamilia[1][1], amigosFamilia[2][2]);
            Console.WriteLine("Hola {0}, quiero presentarte a {1}", amigosFamilia[1][3], amigosFamilia[0][1]);
            Console.WriteLine("Hola {0}, quiero presentarte a {1}", amigosFamilia[3][1], amigosFamilia[1][2]);
            Console.Read();

        }
    }
}
