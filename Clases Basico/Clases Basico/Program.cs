using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un objeto desde mi clase
            // Es una instancia de Humano

            Humano carlos = new Humano();

            // Accedemos a una variable pública externa
            
            carlos.primerNombre = "Carlos";

            // Llamamos a un método de la clase 

            carlos.presentarme();


            // Creamos una nueva instancia de Humano

            Humano pedro = new Humano();

            pedro.presentarme();



            Humano christian = new Humano();

            christian.primerNombre = "Christian";
            christian.primerApellido = "Garay";

            christian.presentarme();



            Console.Read();

        }
    }
}
