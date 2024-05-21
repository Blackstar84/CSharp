using System;

namespace Array_Irregular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] irregular = new int[3][];

            // Esta es una forma de agregar valores al array irregular

            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[2];

            irregular[0] = new int[]
            {
                2, 3, 8, 9, 10
            };
            irregular[1] = new int[]
            {
                23, 100, 15
            };

            irregular[2] = new int[]
            {
                5, 900
            };


            // Esta es la otra forma de agregar valores al array irregular

            int[][] irregular2 = new int[][]
            {
                  new int[] { 2, 3, 8, 9, 10 },
                  new int[] { 23, 100, 15 },
                  new int[] { 5, 900 }
            };

            Console.WriteLine("El valor en el medio del primer array es {0}", irregular2[0][2]);



            for (int i = 0; i < irregular2.Length; i++)
            {
                Console.WriteLine("Los valores del array {0} son: ", i);

                for (int j = 0; j < irregular2[i].Length; j++)
                {
                    Console.WriteLine("{0}", irregular2[i][j]);
                }
            }

            int[][] arrayIrregular = new int[][]
            {
                new int[] { 0, 2, 4},
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 6, 8, 10},
                new int[] { 20, 30, 40, 50}
            };



            for (int i = 2; i == 2; i++)
            {
                Console.WriteLine("Los valores del array {0} son: ", i);

                for (int j = 0; j < arrayIrregular[i].Length; j++)
                {
                    
                        Console.WriteLine("{0}", arrayIrregular[i][j]);
           
                    
                }
            }

            Console.Read();
        }
    }
}
