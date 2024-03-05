using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // Operadores unarios

            num3 = -num1;
            Console.WriteLine("El valor negativo de num1 es {0}", num3);

            bool haySol = true;

            // Al poner ! es como en los otros lenguajes de programación comprueba por el negativo de ese valor en este caso devolverá false
            // Si el valor de haySol fuera False esto devolvería True
            Console.WriteLine("¿Hay sol? {0}", !haySol);

            // Operadores de Adición

            int num = 0;

            num++;

            Console.WriteLine("num es {0}", num);
            // Esto va a aumentar el valor de num en la siguiente impresión no en esta
            Console.WriteLine("num es {0}", num++);
            Console.WriteLine("num es {0}", num);

            // Operadores de Sustracción
            num--;
            Console.WriteLine("num es {0}", num);
            // Esto va a disminuir el valor de num en esta línea
            Console.WriteLine("num es {0}", --num);
            Console.WriteLine("num es {0}", num);

            // Operadores Matemáticos

            int resultado = num1 + num2;
            Console.WriteLine("El resultado de {0} + {1} es igual a = {2} ", num1, num2, resultado);

            resultado = num1 - num2;
            Console.WriteLine("El resultado de {0} - {1} es igual a = {2} ", num1, num2, resultado);

            resultado = num1 * num2;
            Console.WriteLine("El resultado de {0} - {1} es igual a = {2} ", num1, num2, resultado);

            resultado = num1 / num2;
            Console.WriteLine("El resultado de {0} / {1} es igual a = {2} ", num1, num2, resultado);

            // Operador Modular

            resultado = num1 % num2;
            Console.WriteLine("El resultado de {0} % {1} es igual a = {2} ", num1, num2, resultado);

            // Operadores Relacionales

            bool esMenor;

            esMenor = num1 < num2;

            Console.WriteLine("El resultado de {0} < a {1} es igual a {2}", num1, num2, esMenor);

            // Operadores de Igualdad

            bool esIgual;

            esIgual = num1 == num2;

            Console.WriteLine("El resultado de {0} = {1} es {2}", num1, num2, esIgual);

            esIgual = num1 != num2;
            Console.WriteLine("El resultado de {0} != {1} es {2}", num1, num2, esIgual);


            // Operadores Condicionales


            // Y ambas deben ser verdaderas para que sea true

            bool esMenorySoleado;
            esMenorySoleado = esMenor && haySol;
            Console.WriteLine("El resultado de {0} && {1} es igual a {2}", esMenor, haySol, esMenorySoleado);


            // O con que una sea true es verdadero

            esMenorySoleado = esMenor || haySol;
            Console.WriteLine("El resultado de {0} || {1} es igual a {2}", esMenor, haySol, esMenorySoleado);



            Console.Read();

        }
    }
}
