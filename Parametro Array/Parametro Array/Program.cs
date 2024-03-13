using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametro_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = new int[]{8,7,9,3,10,5,4,7 };
            double promeidoResultado = ObtenerPromedio(calificaciones);
            
            foreach (var nota in calificaciones)
            {
                Console.WriteLine("{0}", nota);

            }

            int[] saldos = { 110, 200, 500, -100};

            Credito(saldos);

            foreach (int y in saldos)
            {
                Console.WriteLine(y);
            }

            

            Console.WriteLine("El promedio es {0}", promeidoResultado);

            Console.Read();
        }

        static double ObtenerPromedio(int[] arrayDePuntajes)
        {
            int cantidad = arrayDePuntajes.Length;
            double promedio;
            int suma = 0;

            for (int i = 0; i < cantidad; i++)
            {
                suma += arrayDePuntajes[i];
            }

            promedio = (double) suma / cantidad;

            return promedio;

        }

        static void Credito(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] += 200;
            }

        }
    }
}
