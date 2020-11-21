﻿/* Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior". */

using System;

namespace uri_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiorAB;

            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            if (maiorAB > c)
            {
                Console.WriteLine(maiorAB + " eh o maior");
            }
            else
            {
                Console.WriteLine(c + " eh o maior");
            }
        }
    }
}
