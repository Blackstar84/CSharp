using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            //while (contador < 10)
            //{
            //    Console.WriteLine("Número {0}", contador);
            //    contador++;
            //}

            string textoIngresado = "";

            while (textoIngresado.Equals(""))
            {
                Console.WriteLine("Por favor presione enter cada vez que un alumno ingrese al bus. Para finalizar ingrese otro valor");
                textoIngresado = Console.ReadLine();
                contador++;
                Console.WriteLine("Alumnos en el bus: {0}", contador);
            }

            Console.Read();
        }
    }
}
