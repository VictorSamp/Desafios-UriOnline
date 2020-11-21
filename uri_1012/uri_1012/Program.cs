/* Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal. */

using System;
using System.Globalization;

namespace uri_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaTriangulo, areaCirculo, pi = 3.14159, areaTrapezio, areaQuadrado, areaRetangulo;

            string[] dados = Console.ReadLine().Split(' ');

            a = double.Parse(dados[0], CultureInfo.InvariantCulture);
            b = double.Parse(dados[1], CultureInfo.InvariantCulture);
            c = double.Parse(dados[2], CultureInfo.InvariantCulture);

            areaTriangulo = a * c / 2;
            areaCirculo = pi * Math.Pow(c, 2);
            areaTrapezio = (a + b) * c / 2;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
