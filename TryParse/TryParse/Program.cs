using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Se utiliza para convertir un string en un tipo de dato numérico, como un integer.

            string numeroComoString = "128";
            int valorParseado;

            bool exito = int.TryParse(numeroComoString, out valorParseado);

            //Console.WriteLine(valorParseado); //Devolverá el 128 como número en caso haya podido ser convertido
            //Console.WriteLine(exito); // Devolverá true en caso la conversión haya sido realizada de manera exitosa
            
            if (exito )
            {
                Console.WriteLine("Parsin exitoso - el número es: {0}", valorParseado);
            }else
            {
                Console.WriteLine("Parsing fallido");
            }

            float valorFloatParseado;

            bool exitoFloat = float.TryParse(numeroComoString,out valorFloatParseado);

            if (exitoFloat)
            {
                Console.WriteLine("Parsin exitoso - el número es: {0}", valorFloatParseado);
            }
            else
            {
                Console.WriteLine("Parsing fallido");
            }

            Console.Read();

        }
    }
}
