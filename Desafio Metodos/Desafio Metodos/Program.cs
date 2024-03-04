using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string amigo1 = "Juan Valdez", amigo2 = "Jorgete", amigo3 = "Christian";
            
            SaludarAmigo(amigo1);
            SaludarAmigo(amigo2);
            SaludarAmigo(amigo3);

            Console.Read();
        }

        public static void SaludarAmigo(string nombre)
        {
            Console.WriteLine("¡Hola {0}, que tenga un buen día!", nombre);
        }
    }
}
