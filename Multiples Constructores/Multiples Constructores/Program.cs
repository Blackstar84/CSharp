using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Humano humanoBasico = new Humano();

            Humano humanoSinEdad = new Humano("Carlos","Almada","marrón");

            Humano victoria = new Humano("Victoria", "Aranda", "azules", 34);

            Humano nombreApellido = new Humano("Carlos", "Almada");

            Humano nombreEdad = new Humano("Carlos", 39);

            humanoBasico.presentarme();

            humanoSinEdad.presentarme();

            victoria.presentarme();

            nombreApellido.presentarme();
            nombreEdad.presentarme();

            Console.Read();
        }
    }
}
