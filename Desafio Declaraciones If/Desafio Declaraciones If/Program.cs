using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Declaraciones_If
{
    internal class Program
    {
        static string nombreDeUsuario;
        static string password;
        static void Main(string[] args)
        {

            Registro();
            Ingreso();

            Console.Read();
        }

        public static void Registro()
        {
            Console.WriteLine("Para registrarse proporcione un nombre de usuario: ");
            nombreDeUsuario = Console.ReadLine();

            Console.WriteLine("Ingrese una contraseña");
            password = Console.ReadLine();

            Console.WriteLine("Usuario Registrado exitosamente!");
            Console.WriteLine("------------------------------------");

        }
        public static void Ingreso()
        {
            Console.WriteLine("Por favor ingrese su nombre de usuario");

            if (nombreDeUsuario == Console.ReadLine())
            {
                Console.WriteLine("Por favor ingrese su contraseña");

                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Ingreso exitoso!");
                }
                else
                {
                    Console.WriteLine("Password incorrecto, por favor reinicie el programa");
                }
            }else
            {
                Console.WriteLine("Usuario incorrecto, por favor reinicie el programa");
            }
        }
    }
}
