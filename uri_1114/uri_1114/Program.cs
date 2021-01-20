using System;

namespace uri_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            input = Console.ReadLine();

            while (input != "2002")
            {
                Console.WriteLine("Senha Invalida");

                input = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
