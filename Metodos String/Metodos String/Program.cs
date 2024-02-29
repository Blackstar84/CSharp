using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Algunos Métodos de String

            // SubString Se utiliza para obtener una porción del string comenzando desde un índice en particular.

            string prueba = " Hola que tal soy un texto de prueba ";
            string cortado = prueba.Substring(3);

            // ToLower() Se utiliza para convertir todos los caracteres de un string en minúsculas.

            string minus = prueba.ToLower();

            // ToUpper() Se utiliza para convertir todos los caracteres de un string en mayúsculas.

            string mayus = prueba.ToUpper();

            
            // Trim() Se utiliza eliminar todos los espacios en blanco iniciales y finales de un string.

            string trimmWord = prueba.Trim();

            // IndexOf() Se utiliza para obtener el índice de la primera aparición de un caracter dentro de un string.

            int indice = prueba.IndexOf("y");

            // IsNullOrWhiteSpace()  Devuelve "true" tanto si el string es nulo o si está en blanco. De lo contrario devueve "false".
            bool hia = string.IsNullOrEmpty(prueba);


            Console.WriteLine(hia);
            // Console.WriteLine(trimmWord);


            // Demostración de las Funciones de String

            string nombre = "Carlos";
            string apellido = "Almada";

            // Aquí agregamos un espacio en blanco al inicio, entre el nombre y el apellido y un espacio en blanco al final
            string nombreCompleto = string.Concat(" ", nombre, " ", apellido, " ");

            Console.WriteLine(nombreCompleto);

            Console.WriteLine(nombreCompleto.Trim());

            // String.Format Se utiliza para insertar el objeto o el valor de la variable dentro de otro string

            var nombre2 = "Federico";
            String.Format("Mi nombre es {0}", nombre);


            ///Console.WriteLine(cortado);
            Console.Read();


        }

    }
}
