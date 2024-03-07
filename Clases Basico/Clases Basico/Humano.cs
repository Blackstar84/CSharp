using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Basico
{
    internal class Humano
    {
        // Crear un Miembro Variable

        public string primerNombre;
        public string primerApellido;

        // Miembro Método

        public void presentarme()
        {
            Console.WriteLine("Hola soy {0} {1}", primerNombre, primerApellido);
        }

        
    }
}
