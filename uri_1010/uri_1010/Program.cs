/* Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto. */

using System;
using System.Globalization;

namespace uri_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, quantidadePeca1, codigoPeca2, quantidadePeca2;
            double valorUn1, valorUn2, total;

            string[] peca1 = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(peca1[0]);
            quantidadePeca1 = int.Parse(peca1[1]);
            valorUn1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(peca2[0]);
            quantidadePeca2 = int.Parse(peca2[1]);
            valorUn2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            total = quantidadePeca1 * valorUn1 + quantidadePeca2 * valorUn2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
