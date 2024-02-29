using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miString = "15";
            string miSegundoString = "10";

            string resultado = miString + miSegundoString;
            int num1 = Int32.Parse(miString);
            int num2 = Int32.Parse(miSegundoString);


            int resultado2 = num1 + num2;


            string miString2 = "15";
            int verdad;
            bool conversionExitosa = Int32.TryParse(miString2, out verdad);


            Console.Write(verdad);
            Console.WriteLine("¿Puedo convertir el string en número entero? " + (verdad == 0 ? "No" : "Si"));

            //Console.WriteLine(resultado2);
            //Console.WriteLine(resultado);
            Console.Read();
        }
    }
}
