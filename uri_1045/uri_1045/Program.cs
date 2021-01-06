using System;
using System.Globalization;

namespace uri_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            double[] vetorOrdenado;
            double ladoA, ladoB, ladoC;

            input = Console.ReadLine().Split(' ');

            vetorOrdenado = new double[3];
            vetorOrdenado[0] = double.Parse(input[0], CultureInfo.InvariantCulture);
            vetorOrdenado[1] = double.Parse(input[1], CultureInfo.InvariantCulture);
            vetorOrdenado[2] = double.Parse(input[2], CultureInfo.InvariantCulture);
            Array.Sort(vetorOrdenado);
            Array.Reverse(vetorOrdenado);

            ladoA = vetorOrdenado[0];
            ladoB = vetorOrdenado[1];
            ladoC = vetorOrdenado[2];

            if (ladoA >= (ladoB + ladoC))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(ladoA, 2) == (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(ladoA, 2) > (Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
