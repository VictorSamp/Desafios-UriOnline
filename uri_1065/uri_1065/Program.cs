using System;

namespace uri_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, contador = 0;            

            for (int i = 0; i < 5; i++)
            {
                input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    contador += 1;
                }
            }

            Console.WriteLine("{0} valores pares", contador);
        }
    }
}
