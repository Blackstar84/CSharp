internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;

        for (int contador = 2; contador < 50; contador += 2)
        {
            if (contador > 10)
            {
                break;
            }
            suma += contador;
        }

        Console.WriteLine(suma);
    }
}