using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Tipos_De_Datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte miByte = 25;
            Console.WriteLine(miByte);
            sbyte miSbyte = 15;
            Console.WriteLine(miSbyte);
            int miInt = 12318925;
            Console.WriteLine(miInt);
            uint miUint = 123091;
            Console.WriteLine(miUint);
            short miShort = -32768;
            Console.WriteLine(miShort);
            ushort miUshort = 65535;
            Console.WriteLine(miUshort);
            float miFloat = -31.1289f;
            Console.WriteLine(miFloat);
            double miDouble = -12.1231250;
            Console.WriteLine(miDouble);
            char miChar = 'A';
            Console.WriteLine(miChar);
            bool miBool = true;
            Console.WriteLine(miBool);
            string miTexto = "Yo controlo el texto";
            Console.WriteLine(miTexto);
            string numTexto = "15";

            int miNumeroDesdeTexto = int.Parse(numTexto);
            Console.WriteLine(miNumeroDesdeTexto);
            Console.Read();
        }
    }
}
