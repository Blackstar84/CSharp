using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingresos_del_Usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calcular());
            CalcularSinRetorno();
            Console.Read();
        }

        public static int Calcular()
        {
            Console.WriteLine("Por favor, ingrese un número: ");
            string numero1Input = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese otro número: ");
            string numero2Input = Console.ReadLine();

            int num1 = int.Parse(numero1Input);
            int num2 = int.Parse(numero2Input);

            int resultado = num1 + num2;

            return resultado;
        }

        public static void CalcularSinRetorno()
        {
            Console.WriteLine("Por favor, ingrese un número: ");
            string numero1Input = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese otro número: ");
            string numero2Input = Console.ReadLine();

            int num1 = int.Parse(numero1Input);
            int num2 = int.Parse(numero2Input);

            int resultado = num1 + num2;

            Console.WriteLine(resultado);
        }
    }
}
