using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de tipo int sin valores
            var numeros = new List<int>();

            //Lista de tipo int con valores
            var numeros2 = new List<int> { 1, 5, 35, 100 };

            // Agregar y eliminar valores

            // Agrega un integer de valor 7 a la lista
            numeros.Add(7);

            // Elimina un elemento con el valor 7 de la lista
            numeros.Remove(7);

            // Remover un elemento de una posición específica (índice)

            int indice = 0;
            numeros.RemoveAt(indice);

            
            
            // Obener un valor

            // Agregar un integer de valor 25 a la lista

            numeros.Add(25);

            // Asigna a una variable el valor del índice 0 de la lista (25)

            int valor = numeros[0];



            // Limpiar una lista

            numeros.Add(25);
            numeros.Add(50);

            // Elimina todos los elementos de la lista
            numeros.Clear();




            // Listas y Loops

            var numeros3= new List<int> { 5, 10, 15, 20, 25, 30, 35, 40};


            // Loop foreach

            foreach (int elemento in numeros3)
            {
                Console.WriteLine(elemento);
            }


            // Loop For

            for (int i = 0; i < numeros3.Count; i++)
            {
                Console.WriteLine(numeros3[i]);
            }







            Console.Read();

        }
    }
}
