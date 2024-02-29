using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("HOLA");

            Console.Write("BIENVENIDO");


            // Imprime algo y mantiene el cursor en la misma línea
            Console.Write("Hola"); 
            Console.WriteLine();
            // Imprime algo y lleva el cursor a la siguiente línea
            Console.WriteLine("HOLA BIENVENIDO");
            
            // Toma un ingreso simple de tipo string y devuelve el valor ASCII de ese ingreso
            Console.Read();

            // Toma un ingreso string o integer y lo devuelve como valor de Salida
            Console.ReadLine();

            // Toma un inreso simple de tipo string y devuelve la información de la Tecla
            Console.ReadKey();
            Console.Read();
            */

            //Métodos Read y ReadLine

            // ForegroundColor y BackgroundColor Son Propiedades

            // Cambia el color de las letras de la consola, en este caso serían letras de color verde oscuro
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Agrega un fondo a las letras, en este caso tendría un fondo de color blanco
            Console.BackgroundColor = ConsoleColor.White;

            // Con Clear hacemos que se limpie toda la información del buffer y que el fondo que aplicamos sea aplicada a toda la consola y no solo a las letras
            Console.Clear();

            // Write y WriteLine son métodos

            Console.Write("Ingresar un string y presionar Enter:");
            string leerEntrada = Console.ReadLine();

            Console.WriteLine("Usted ha ingresado {0}", leerEntrada);
            //Console.Read();

            Console.Write("Ingresar una tecla y presionar Enter:");
            int valorAscii = Console.Read();
            Console.WriteLine("El valor ASCII es {0}",valorAscii);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.ReadKey();


        }
    }
}
