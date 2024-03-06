using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_Ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // condición ? primera_expresión : segunda_expresion
            // La condición sólo puede ser verdadera o falsa (true / false)
            // el operador condicional es correcto, osea que es asociativo
            // la expresión a ? b : c ? d : e
            // es evaluada como a ? b : (c ? d : e)
            // no como (a ? b: c) ? d : e

            int temperatura = -5;
            string estadoDelAgua;

            if (temperatura < 0)
            {
                estadoDelAgua = "Sólido";
            }
            else
            {
                estadoDelAgua = "Líquido";
            }
            Console.WriteLine("El estado del agua es {0}", estadoDelAgua);

            temperatura += 130;


            estadoDelAgua = temperatura < 0 ? "Sólido" : "Líquido";


            /*
             * Lo que hace aquí es primeramente preguntar si temperatura es mayor a 99, caso sea verdadero devolverá Gaseoso, caso contrario entra
             * a otra validación que sería el equivalente a un else if, donde pregunta si temperatura < 0, caso sea verdadero devolverá Sólido, 
             * caso contrario Líquido uno de estos valores es el que será utilizado en caso que la temperatura sea menor a 99 y no se cumpla la primera
             * condición
             * 
             * temperatura > 99 ? Gaseoso : (Sólido o Líquido)
             */
            estadoDelAgua = temperatura > 99 ? "Gaseoso" : temperatura < 0 ? "Sólido" : "Líquido";


            Console.WriteLine("El estado del agua es {0}", estadoDelAgua);


            Console.Read();
        }
    }
}
