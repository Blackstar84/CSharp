using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Basico_2
{
    internal class Humano
    {
        // Miembro Variable
        // Al ser declaradas como private sólo van a poder ser utilizadas dentro de la clase Humano
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;

        // Miembro Constructor
        public Humano(string primerNombre, string apellido, string colorOjos, int edad) 
        {
            this.primerNombre = primerNombre;
            // this hace referencia al miembro variable, a esto le decimos que se asigne el valor pasado por parámetro
            // dentro del constructor, entonces al miembro variable apellido le pasamos el valor que recibimos de nombre apellido en el constructor
            this.apellido = apellido;

            this.colorOjos = colorOjos;
            this.edad = edad;
        }


        // Miembro Método
        public void presentarme()
        {
            Console.WriteLine("Hola, soy {0} {1} tengo {2} año{3} de edad. Mi color de ojos es {4}", primerNombre, apellido, edad, edad ==1 ? "" : "s", colorOjos);
        }
    }
}
