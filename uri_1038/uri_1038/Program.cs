using System;
using System.Globalization;

namespace uri_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int codigo, quantidade;
            double valor = 0, total;

            input = Console.ReadLine().Split(' ');

            codigo = int.Parse(input[0]);
            quantidade = int.Parse(input[1]);

            switch (codigo)
            {
                case 1:
                    valor = 4.00;
                    break;
                case 2:
                    valor = 4.50;
                    break;
                case 3:
                    valor = 5.00;
                    break;
                case 4:
                    valor = 2.00;
                    break;
                case 5:
                    valor = 1.50;
                    break;
            }

            total = quantidade * valor;

            Console.WriteLine("Total: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
