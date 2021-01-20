using System;
using System.Globalization;

namespace uri_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double input, media = 0;
            int contador = 0;

            for (int i = 0; i < 6; i++)
            {
                input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (input >= 0)
                {
                    contador += 1;
                    media += input;
                }
            }

            media = media / contador;

            Console.WriteLine("{0} valores positivos", contador);
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}