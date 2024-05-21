using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

           /* for (int j = 0;j < nums.Length;j++)
            {
                Console.WriteLine("El valor del índice {0} es {1}", j, nums[j]);
            }*/

            foreach (int k in nums)
            {
                Console.WriteLine("El valor del índice {0} es {1}", k, nums[k]);
            }

            string[]amigos = {"Pedro", "Jorgete", "Christian", "Juacados", "Oscar"};

            foreach (string amigo in amigos)
            {
                Console.WriteLine("Hola, {0}, te aprecio mucho.", amigo);
            }



            Console.Read();
        }
    }
}
