using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace uri_1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double input, media;
            List<double> notas = new List<double> { };

            while (notas.Count != 2)
            {
                input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (input >= 0.0 && input <= 10.0)
                {
                    notas.Add(input);
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            media = notas.Sum() / notas.Count();

            Console.WriteLine("media = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
