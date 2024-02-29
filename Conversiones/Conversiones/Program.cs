using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversión Explícita

            double miDouble = 13.37;

            int miInt;

            miInt = (int)miDouble;

            // Conversión Implícita

            int num = 123456;
            long numg = num;

            float miFloat = 13.37F;
            double miNuevoDouble = miFloat;

            bool elSolBrilla = true;

            string miBoolString = elSolBrilla.ToString();
            Console.WriteLine(miBoolString);
            Console.ReadKey();

            // Conversión de Tipo

            string miString = miDouble.ToString();

            string miString2 = miFloat.ToString();

            Console.WriteLine(miString);
            Console.WriteLine(miString2);
            Console.Read();
            Console.WriteLine(miNuevoDouble);
            Console.WriteLine(numg);
            Console.WriteLine(miInt);
            Console.Read();
        }
    }
}
