using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deafio_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miNombre;
            Console.WriteLine("Por favor, ingresa tu nombre y presiona Enter: ");
            miNombre = Console.ReadLine();

            string miNombreMayuscula = String.Format("En mayúsculas es {0}", miNombre.ToUpper());
            string miNombreMinisculas = String.Format("En minúsculas es {0}", miNombre.ToLower());
            string miNombreSinEspacios = String.Format("Sin espacios sería {0}", miNombre.Trim());
            string minombreSubstring = String.Format("Valor del substring es {0}", miNombre.Substring(0, 5));

            Console.WriteLine(miNombreMayuscula);
            Console.WriteLine(miNombreMinisculas);
            Console.WriteLine(miNombreSinEspacios);
            Console.WriteLine(minombreSubstring);

            Console.ReadKey();

        }
    }
}
