using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            int num3;

            double d1 = 3.2;
            double d2 = 1.337;

            double sumd = d1 + d2;

            double sumX = d1 + num2;

            num3 = 25;

            int num4, num5, num6;

            float f1 = 3.5f;
            float f2 = 7.7f;
            float sumF;

            sumF = f1 + f2;

            string MiNombre = "Carlos";
            string mensaje = "Mi nombre es " + MiNombre;

            string MensMay = mensaje.ToUpper();

            string MensMin = mensaje.ToLower();
            string cadenaModificada;
            string cadena = "Cadena;de;texto";
            cadenaModificada = cadena.Replace(';', ' ');


            Console.WriteLine("La suma de " + num1 + " más " + num2 + " da como resultado " + sum);
            Console.WriteLine("La suma de " + d1 + " más " + d2 + " da como resultado " + sumd);
            Console.WriteLine("La suma de " + d1 + " más " + num2 + " da como resultado " + sumX);
            Console.WriteLine("La suma de " + f1 + " más " + f2 + " da como resultado " + sumF);
            Console.WriteLine("Mi nombre es " + MiNombre);
            Console.WriteLine(mensaje);
            Console.WriteLine(MensMay);
            Console.WriteLine(MensMin);
            Console.WriteLine(cadenaModificada);
            Console.Read();
        }
    }
}
