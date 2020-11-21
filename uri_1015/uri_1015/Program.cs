/* Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:

Distancia =

Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, com 4 casas após o ponto decimal. */

using System;
using System.Globalization;

namespace uri_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            string[] p2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
