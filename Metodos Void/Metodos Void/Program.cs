using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecifico("Carlos Almada");
            Console.Read();
        }

        // Nivel de Acceso - (static) para que pueda ser invocado en main debe ser declarado como static - Tipo de Retorno - Nombre del Método(Parámetro1, Parámetro2)
        public static void EscribeAlgo()
        { 
            Console.WriteLine("Yo nací en un método");
            
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
            
        }
    }
}
