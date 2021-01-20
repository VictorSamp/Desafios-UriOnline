using System;
using System.Globalization;

namespace uri_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            double ladoA, ladoB, ladoC, area, perimetro;

            input = Console.ReadLine().Split(' ');

            ladoA = double.Parse(input[0], CultureInfo.InvariantCulture);
            ladoB = double.Parse(input[1], CultureInfo.InvariantCulture);
            ladoC = double.Parse(input[2], CultureInfo.InvariantCulture);

            if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
            {
                perimetro = ladoA + ladoB + ladoC;
                Console.WriteLine("Perimetro = {0}", perimetro.ToString("F1", CultureInfo.InvariantCulture));
                return;
            }

            area = ((ladoA + ladoB) * ladoC) / 2;
            Console.WriteLine("Area = {0}", area.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
