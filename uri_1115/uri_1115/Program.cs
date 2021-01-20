using System;

namespace uri_1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int x, y;

            input = Console.ReadLine().Split(' ');

            x = int.Parse(input[0]);
            y = int.Parse(input[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }

                input = Console.ReadLine().Split(' ');
                x = int.Parse(input[0]);
                y = int.Parse(input[1]);
            }
            
        }
    }
}
