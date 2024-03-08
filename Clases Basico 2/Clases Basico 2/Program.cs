using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Basico_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano laura = new Humano("Laura", "López", "azules", 1);
            Humano  carlos = new Humano("Carlos", "Almada", "marrones", 39);


            laura.presentarme();
            carlos.presentarme();



            Console.Read();
            
        }
    }
}
