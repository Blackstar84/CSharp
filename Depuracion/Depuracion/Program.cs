using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depuracion
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable que almacena la lista completa de amigos
            var amigos = new List<string> { "María", "Ana", "Martina", "Juan", "Leonardo", "Carlos", "Marianela"};
            //var amigos = new List<string>();
            // variable que contiene los amigos que irán a la fiesta
            var amigosFiesta = ObtenerAmigosFiesta(amigos, 13);
            //var amigosFiesta = ObtenerAmigosFiesta(null, 3);

            foreach (var nombre in amigos)
                Console.WriteLine(nombre);

            // loop para mostrar en pantalla los nombres de los amigos que irán a la fiesta
            foreach (var nombre in amigosFiesta)
                Console.WriteLine(nombre);
            Console.Read();

        }

        // Método para cargar la lista de amigos que irán a la fiesta
        public static List<string> ObtenerAmigosFiesta(List<string> lista, int cuenta)
        {
            if (lista == null)
                throw new ArgumentNullException("Lista", "La lista está vacía");
            if (cuenta > lista.Count || cuenta <= 0)
                throw new ArgumentOutOfRangeException("Cuenta", "Cuenta no puede ser más grande que los elementos de la lista o menor a 0");

            // Esta es una lista aparte no modificará la lista original
            var muleto = new List<string>(lista);
            // variable que contendrá la lista de amigos
            var amigosFiesta = new List<string>();

            // Loop para cargar la lista hasta el límite de personas
            while(amigosFiesta.Count < cuenta)
            {
                var amigoActual = ObtenerAmigoFiesta(muleto);
                amigosFiesta.Add(amigoActual);
                muleto.Remove(amigoActual);
            }
            return amigosFiesta;
        }

        /// <summary>
        ///  Esta es la lógica para ver quién es un amigoFiesta
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>

        // Método para elegir cada amigo que asistirá
        public static string ObtenerAmigoFiesta(List<string> lista)
        {
            // Variable que contendrá el amigo con el nombre más corto
            string nombreMasCorto = lista[0];
            // Loop para revisar la lista y detectar al que tiene el nombre más corto
            for(var i = 0; i<lista.Count; i++)
            {
                if(lista[i].Length < nombreMasCorto.Length)
                {
                    nombreMasCorto = lista[i];
                }
            }
            return nombreMasCorto;
        }
    }
}
