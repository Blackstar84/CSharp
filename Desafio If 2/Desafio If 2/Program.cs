using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_If_2
{
    internal class Program
    {
        static int record = 200;
        static string recordPersona = "Carlos";

        static void Main(string[] args)
        {
            RevisarRecord(100, "José");
            RevisarRecord(210, "Pedro");
            RevisarRecord(250, "Manuel");

            Console.Read();
        }

        public static void RevisarRecord(int puntaje, string jugador)
        {
            if (puntaje > record) 
            {
                record = puntaje;
                recordPersona = jugador;

                Console.WriteLine("El nuevo record es {0}", puntaje);
                Console.WriteLine("Fue logrado por {0}", jugador);
            }else
            {
                Console.WriteLine("El record vigente de {0} logrado por {1} no fue superado", record, recordPersona);
            }

        } 
    }
}
