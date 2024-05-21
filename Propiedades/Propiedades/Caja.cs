using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Caja
    {
        // Miembros Variables

        private int largo;
        private int alto;
        // Aquí comentamos como ejemplo para que se sepa que se pueden utilizar las propiedades como variables
        //private int ancho;
        private int volumen;


        public  Caja(int largo, int alto, int ancho)
        {
            this.largo = largo;
            this.alto = alto;
            this.Ancho = ancho;
        }
        

        // Una manera rápida de generar setters y getters en lugar de usar la forma larga, escribimos prop y damos tab 2 veces
        // Y luego reemplazamos el nombre

        // Propiedad Auto-Implementada

        public int Volumen {

            set
            {
                volumen = value;
            } 
            get
            {
                return Alto * Ancho * Largo;
            }
        }

        public int Alto {
            get
            {
                return alto;
            }
            set
            {
                // Esto es para convertir el valor a positivo en caso el usuario ingrese un valor negativo
                if (value < 0) value = -value;
                // Esto sería para tirar un error si el usuario mete un valor negativo
                //if (value < 0) throw new Exception("El tamaño debe ser positivo.");
                alto = value;
            }
        }
        // De esta manera ya no es necesario declarar en las variables al inicio por ese motivo comentamos la declaración de la variable ancho
        // Utilizamos la propiedad como variable, la variable ya no existe
        public int Ancho { get; set; }


        // Manera larga
        //public int Largo
        //{
        //    get 
        //    { 
        //        return largo; 
        //    }
        //    set
        //    {
        //        largo = value;
        //    }
        //}

        // Método corto

        // Las propiedades se escriben con mayúsculas y las variables en minúsculas
        public int Largo
        {
            get => largo;
            set => largo = value;
        }


        // Miembro Método

        public void MuestraInfo()
        {
            Console.WriteLine("El largo es {0}. La altura es {1}. El ancho es {2}. Por lo tanto el volumen es {3}",
                Largo, Alto, Ancho, Volumen);
            /*
            Console.WriteLine("El largo es {0}. La altura es {1}. El ancho es {2}. Por lo tanto el volumen es {3}",
                Largo, Alto, Ancho, volumen = Ancho * Largo * Alto); */
        }




       /* public void SetLargo(int largo)
        {
            this.largo = largo;
        }

        public int GetLargo()
        {
            return this.largo;
        }
       */

    }
}
