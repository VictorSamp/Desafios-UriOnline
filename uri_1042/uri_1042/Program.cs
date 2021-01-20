using System;

namespace uri_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int[] inputConvertido, inputOrdenado;

            input = Console.ReadLine().Split(' ');

            inputConvertido = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputConvertido[i] = int.Parse(input[i]);
            }

            inputOrdenado = new int[inputConvertido.Length];

            for (int j = 0; j < inputConvertido.Length; j++)
            {
                inputOrdenado[j] = inputConvertido[j];
            }

            Array.Sort(inputOrdenado);

            foreach (int numero in inputOrdenado)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("");

            foreach (int numero in inputConvertido)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
