using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja(5, 4, 10);
            Console.WriteLine("El volumen es de {0}", caja.Volumen);
            Console.WriteLine("La superficie frontal de la caja es {0}", caja.SuperficieFrontal);
            caja.MuestraInfo();
            Console.Read();
        }
    }
}
