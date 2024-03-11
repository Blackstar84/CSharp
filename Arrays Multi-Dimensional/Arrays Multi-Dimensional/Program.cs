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


            string[,,] array3D = new string[,,]
            {
                {
                    { "A", "B", "C"},
                    { "D", "E", "F"},
                    { "E", "H", "I"}
                },
                {
                    {"J", "K", "L" },
                    {"M", "N", "O"},
                    {"P", "Q", "R" }
                },
                {
                    {"S", "T", "U"},
                    {"V", "W", "X"},
                    {"Y", "Z", "*"},
                }

            };


            string[,] otroArray2D = new string[3, 2] 
            {
                { "María:", "López"},
                { "Franco", "Miller"},
                {"Juana",  "Garay" }
            };



            Console.WriteLine("El valor central es {0}", array2D[1,1]);
            Console.WriteLine("Imprimir la letra G {0}", array2D[2,0]);

            Console.WriteLine("El valor A es {0}", array3D[0,0,0]);
            Console.WriteLine("El valor E es {0}", array3D[0, 1, 1]);
            Console.WriteLine("El valor V es {0}", array3D[2, 1, 0]);

            otroArray2D[1, 1] = "Paco";

            int dimension = otroArray2D.Rank;

            int[,] a2D = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("Las dimensiones del array son {0}", dimension);

            foreach (var item in otroArray2D)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("El valor de Miller ha sido cambiado a {0}", otroArray2D[1,1]);




            Console.Read();

        }
    }
}
