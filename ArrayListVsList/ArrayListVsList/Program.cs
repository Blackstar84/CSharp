using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListVsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inmutable - Limitado a 1 tipo

            int[] puntajes = new int[] { 99, 96, 87, 76};

            // Listas
            // Podemos agregar nuevos valores, esto no podemos hacerlo con los array que ya vienen definidos
            List<int> lista = new List<int> {1, 2, 3, 4 };
            
            lista.Add(0);
            lista.Add(32);

            // Ordenar lista
            // Con Sort() ordenamos por defecto de manera ascendente en este ejemplo del 0 al 32

            lista.Sort();

            // Eliminará a partir del índice 2, eliminaría 2 elementos
            lista.RemoveRange(2, 2);

            

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }


            // Ver si exite un valor específico en la lista, devuelve True o False

            Console.WriteLine(lista.Contains(4));

            // Verificar en que índice se encuentra un valor específico

            int indice = lista.FindIndex(x => x == 4);

            Console.WriteLine(lista[indice]);

            lista.RemoveAt(indice);

            lista.ForEach(i => Console.WriteLine(i));


            
            
            
            
            // ArrayList
            
            
            ArrayList arrl = new ArrayList();

            arrl.Add(1);
            arrl.Add("dos");
            arrl.Add("3");
            arrl.Add(new numero { n = 4 });

            foreach (Object o in arrl)
            {
                Console.WriteLine(o);
            }


            Console.Read();






        }

        
    }
    class numero
    {
        public int n { get; set; }

        // Sobreescribimos el método ToString para mostrar el valor del número
        public override string ToString()
        {
            return n.ToString();
        }

    }
}
