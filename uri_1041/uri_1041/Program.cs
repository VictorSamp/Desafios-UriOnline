using System;
using System.Globalization;

namespace uri_1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            double pontoX, pontoY;

            input = Console.ReadLine().Split(' ');

            pontoX = double.Parse(input[0], CultureInfo.InvariantCulture);
            pontoY = double.Parse(input[1], CultureInfo.InvariantCulture);

            if (pontoX == 0.0 && pontoY == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (pontoX == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (pontoY == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (pontoX > 0.0 && pontoY > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (pontoX < 0.0 && pontoY > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (pontoX < 0.0 && pontoY < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
