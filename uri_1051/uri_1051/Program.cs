using System;
using System.Globalization;

namespace uri_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorSalario;

            valorSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valorSalario >= 0.00 && valorSalario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                double valorTaxado = 0.00, valorImposto = 0.00;

                if (valorSalario >= 2000.01 && valorSalario <= 3000.00)
                {
                    valorTaxado = valorSalario - 2000.00;
                    valorImposto = valorTaxado * ((double)8 / 100.00);
                }
                else if (valorSalario >= 3000.01 && valorSalario <= 4500.00)
                {
                    valorTaxado = valorSalario - 2000.00;
                    valorImposto = valorTaxado * ((double)18 / 100.00);
                }
                else if (valorSalario > 4500.00)
                {
                    valorTaxado = valorSalario - 2000.00;
                    valorImposto = valorTaxado * ((double)28 / 100.00);
                }

                Console.WriteLine("R$ " + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
