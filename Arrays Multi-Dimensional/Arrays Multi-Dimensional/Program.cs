using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Multi_Dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array 2D
            string[,] matriz2D;

            // Array 3D
            string[,,] matriz3D;

            string[,] array2D = new string[,]
            {
                {"A", "B", "C"},
                {"D", "E", "F"},
                {"G", "H", "I"},
            };


            Console.WriteLine("El valor central es {0}", array2D[1,1]);
            Console.WriteLine("Imprimir la letra G {0}", array2D[2,0]);
            Console.Read();

        }
    }
}
