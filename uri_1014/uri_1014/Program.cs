/* Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).

Entrada
O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

Saída
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l". */

using System;
using System.Globalization;

namespace uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double totalGasto, consumoMedio;

            distancia = int.Parse(Console.ReadLine());
            totalGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distancia / totalGasto;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
