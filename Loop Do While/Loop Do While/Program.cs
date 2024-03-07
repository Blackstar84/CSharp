using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int contador = 0;
            //

            //// Se ejecuta al menos una vez
            //do
            //{
            //    Console.WriteLine(contador);
            //    contador++;

            //} while (contador < 5);

            int largoDeTexto = 0;
            string textoCompleto = "";

            do
            {
                Console.WriteLine("Por favor, ingresa el nombre de un amigo");
                string nombreAmigo = Console.ReadLine();

                int largoActual = nombreAmigo.Length;
                Console.WriteLine(largoActual);

                largoDeTexto += largoActual;
                textoCompleto += nombreAmigo;
            }while (largoDeTexto < 20);
            Console.WriteLine("Gracias, eso es todo {0}", textoCompleto);
            Console.Read();
        }
    }
}
