using System;

namespace uri_1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            
            input = int.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                if (input % 2 != 0)
                {
                    Console.WriteLine(input);
                }
                else
                {
                    i--;
                }

                input++;
            }
        }
    }
}
