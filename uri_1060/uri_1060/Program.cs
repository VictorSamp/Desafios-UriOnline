using System;
using System.Globalization;

namespace uri_1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            int contador = 0;

            for (int i = 0; i < 6; i++)
            {
                input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (input >= 0)
                {
                    contador += 1;
                }
            }

            Console.WriteLine("{0} valores positivos", contador);
        }
    }
}
