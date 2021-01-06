using System;
using System.Globalization;

namespace uri_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, novoSalario, reajusteGanho, percentualDeReajuste;

            salarioAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salarioAtual > 0 && salarioAtual <= 400.00)
            {
                percentualDeReajuste = 15;
            }
            else if (salarioAtual <= 800.00)
            {
                percentualDeReajuste = 12;
            }
            else if (salarioAtual <= 1200.00)
            {
                percentualDeReajuste = 10;
            }
            else if (salarioAtual <= 2000.00)
            {
                percentualDeReajuste = 7;
            }
            else
            {
                percentualDeReajuste = 4;
            }

            novoSalario = salarioAtual + (salarioAtual * (percentualDeReajuste / 100));
            reajusteGanho = novoSalario - salarioAtual;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentualDeReajuste + " %");
        }
    }
}
