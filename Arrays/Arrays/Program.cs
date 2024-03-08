using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primera manera de crear arrays
            int[] calificaciones = new int[5];

            calificaciones[0] = 10;
            calificaciones[1] = 7;
            calificaciones[2] = 9;
            calificaciones[3] = 3;
            calificaciones[4] = 7;

            string ingreso = Console.ReadLine();

            calificaciones[0] = int.Parse(ingreso);

            Console.WriteLine("Primera Calificación: {0}", calificaciones[0]);
            //Console.Read();

            // Segunda manera de crear arrays

            int[] edades = {17, 15, 16, 15, 17};

            // Tercera manera de crear arrays

            int[] faltasAlColegio = new int[] {3,5,7,3,4,5 };

            Console.WriteLine("El array faltasAlColegio tiene {0} casos", faltasAlColegio.Length);

            Console.Read();



        }
    }
}
