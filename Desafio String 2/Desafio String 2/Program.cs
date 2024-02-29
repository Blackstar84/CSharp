using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_String_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto aquí: ");
            string texto = Console.ReadLine();

            Console.WriteLine("Ingrese un caracter que desee buscar: ");
            // Limitamos a 1 caracter el texto de lo que ingrese el usuario
            char buscarCaracter = Console.ReadLine()[0];

            int buscarIndice = texto.IndexOf(buscarCaracter);

            Console.WriteLine("El índice del caracter {0} en el texto es {1}",buscarCaracter, buscarIndice);


            Console.WriteLine("Ingrese su nombre: ");

            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido: ");

            string apellido = Console.ReadLine();

            string nombreCompleto = String.Concat(nombre, " ", apellido);

            Console.WriteLine("El nombre completo es {0}",nombreCompleto);
            


            Console.Read();


        }
    }
}
