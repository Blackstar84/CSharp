using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja(5, 4, 10);

            Console.WriteLine("El volumen es de {0}", caja.Volumen);
            // Al intentar asignar un valor aquí ya nos mostrará un error ya que es de sólo lectura
            // sólo tiene el método get y no set motivo por el cuál no podemos asignar un nuevo valor

            // caja.SuperficieFrontal = 4;

            Console.WriteLine("La superficie frontal de la caja es {0}", caja.SuperficieFrontal);

            Console.Read();
        }
    }
}
