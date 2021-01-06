using System;
using System.Globalization;

namespace uri_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;

            input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (input >= 0 && input <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (input > 25 && input <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (input > 50 && input <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (input > 75 && input <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
