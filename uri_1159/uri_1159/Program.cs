using System;
using System.Collections.Generic;
using System.Linq;

namespace uri_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            List<int> listaNumeros = new List<int> { };

            input = int.Parse(Console.ReadLine());

            while (input != 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (input % 2 == 0)
                    {
                        listaNumeros.Add(input);
                    }
                    else
                    {
                        i--;
                    }

                    input++;
                }

                Console.WriteLine(listaNumeros.Sum());
                listaNumeros.Clear();

                input = int.Parse(Console.ReadLine());

            }
        }
    }
}
