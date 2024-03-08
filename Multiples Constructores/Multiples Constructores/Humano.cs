using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_Constructores
{
    internal class Humano
    {

        // Miembro Variable
        // Al ser declaradas como private sólo van a poder ser utilizadas dentro de la clase Humano
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;

        // Constructor por defecto
        public Humano()
        {
            Console.WriteLine("Constructor llamado. Objeto creado.");
        }


        // Miembro Constructor parametrizado
        // Se construye en base a parámetros
        public Humano(string primerNombre, string apellido, string colorOjos, int edad)
        {
            this.primerNombre = primerNombre;
            // this hace referencia al miembro variable, a esto le decimos que se asigne el valor pasado por parámetro
            // dentro del constructor, entonces al miembro variable apellido le pasamos el valor que recibimos de nombre apellido en el constructor
            this.apellido = apellido;

            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        // Este es un Humano sin edad en el constructor
        public Humano(string primerNombre, string apellido, string colorOjos)
        {
            this.primerNombre = primerNombre;
            // this hace referencia al miembro variable, a esto le decimos que se asigne el valor pasado por parámetro
            // dentro del constructor, entonces al miembro variable apellido le pasamos el valor que recibimos de nombre apellido en el constructor
            this.apellido = apellido;

            this.colorOjos = colorOjos;
        }

        public Humano(string primerNombre, string apellido)
        {
            this.primerNombre= primerNombre;
            this.apellido= apellido;
        }

        public Humano(string primerNombre, int edad)
        {
            this.primerNombre = primerNombre;
            this.edad= edad;
        }


        // Miembro Método
        public void presentarme()
        {
            //Console.WriteLine("Hola, soy {0} {1} tengo {2} año{3} de edad. Mi color de ojos es {4}", primerNombre, apellido, edad, edad != 0 ? "" : "s", colorOjos);
            //Console.WriteLine("Hola, soy {0} {1}{2}. Mi color de ojos es {3}", primerNombre, apellido, edad != 0 ? $" tengo {edad} años de edad" : "", colorOjos);
            if (edad != 0 && primerNombre != null && apellido != null && colorOjos != null)
                Console.WriteLine("Hola, soy {0} {1} y tengo {2} años de edad. Mi color de ojos es {3}"
                    , primerNombre, apellido, edad, colorOjos);
            else if (primerNombre != null && apellido != null && colorOjos != null)
                Console.WriteLine("Hola, soy {0} {1}. Mi color de ojos es {2}"
                , primerNombre, apellido, colorOjos);
            else if (primerNombre != null && apellido != null)
                Console.WriteLine("Hola, soy {0} {1}"
                , primerNombre, apellido);
            else if (primerNombre != null && edad != 0)
                Console.WriteLine("Hola, soy {0} y tengo {1} años de edad"
                , primerNombre, edad);



        }


    }
}
