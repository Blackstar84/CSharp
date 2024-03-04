using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_con_valores_Retorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = Sumar(2,4);
            Console.WriteLine(resultado);
            Console.WriteLine(Sumar(14, 47));
            Console.WriteLine(Multiplicar(14, 3));
            Console.WriteLine(Dividir(14, 3));
            Console.Read();
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        //Si aquí pasamos como parámetros int num1 y num2 esto nos devolverá un valor entero luego de realizar la división
        //Ya que primero hace la división de enteros y luego lo convierte a double
        // public static double Dividir(int num1, int num2) esto devolverá un entero 
        public static double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
