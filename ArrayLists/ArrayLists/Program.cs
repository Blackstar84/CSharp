using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declarar un ArrayList

            ArrayList miArrayList = new ArrayList();

            ArrayList miArrayList2 = new ArrayList(100);

            // Agregar elementos al ArrayList
            miArrayList.Add(25);
            miArrayList.Add("Hola");
            miArrayList.Add(13.37);
            miArrayList.Add(13);
            miArrayList.Add(128);
            miArrayList.Add(25.3);

            // Eliminar elementos del ArrayList por valor

            miArrayList.Remove(13);
            // Como vemos tenemos varias veces que elimine el valor 13 pero solamente tenemos uno con ese valor, esto no dará error
            // al no encontrar otro valor 13 simplemente hará caso omiso de esta sentencia y no la ejecutará.
            miArrayList.Remove(13);
            miArrayList.Remove(13);

            // Eliminar elementos del ArrayList por posición

            miArrayList.RemoveAt(0);

            // Contar elementos del ArrayList

            Console.WriteLine(miArrayList.Count);

            double suma = 0;

            foreach(object obj in miArrayList)
            {
                if(obj is int)
                {
                    suma += Convert.ToDouble(obj);
                }else if(obj is double) 
                {
                    suma += (double)obj;
                }else if(obj is string) 
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("La suma es {0}", suma);




            Console.Read();
        }
    }
}
