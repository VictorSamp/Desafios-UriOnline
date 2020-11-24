using System;

namespace uri_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, resto, qtdAnos, qtdMeses, qtdDias, ano = 365, mes = 30;

            input = int.Parse(Console.ReadLine());

            qtdAnos = input / ano;
            resto = input % ano;
            Console.WriteLine(qtdAnos + " ano(s)");

            qtdMeses = resto / mes;
            qtdDias = resto % mes;

            Console.WriteLine(qtdMeses + " mes(es)");
            Console.WriteLine(qtdDias + " dia(s)");
        }
    }
}
