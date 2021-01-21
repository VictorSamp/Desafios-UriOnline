using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace uri_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            double media;
            List<double> numeros = new List<double> { };

            input = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (input >= 0)
            {
                numeros.Add(input);

                input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = numeros.Sum() / numeros.Count();

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
