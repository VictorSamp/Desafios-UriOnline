using System;

namespace uri_1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, contadorPar = 0, contadorImpar = 0, contadorPositivo = 0, contadorNegativo = 0;

            for (int i = 0; i < 5; i++)
            {
                input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    contadorPar += 1;
                }
                else
                {
                    contadorImpar += 1;
                }

                if (input > 0)
                {
                    contadorPositivo += 1;
                }
                else if (input < 0)
                {
                    contadorNegativo += 1;
                }
            }

            Console.WriteLine("{0} valor(es) par(es)", contadorPar);
            Console.WriteLine("{0} valor(es) impar(es)", contadorImpar);
            Console.WriteLine("{0} valor(es) positivo(s)", contadorPositivo);
            Console.WriteLine("{0} valor(es) negativo(s)", contadorNegativo);

        }
    }
}
