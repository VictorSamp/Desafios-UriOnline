using System;

namespace uri_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3;

            input1 = Console.ReadLine();
            input2 = Console.ReadLine();
            input3 = Console.ReadLine();

            switch (input1)
            {
                case "vertebrado":
                    switch (input2)
                    {
                        case "ave":
                            switch (input3)
                            {
                                case "carnivoro":
                                    Console.WriteLine("aguia");
                                    break;

                                case "onivoro":
                                    Console.WriteLine("pomba");
                                    break;
                            }
                            break;
                        case "mamifero":
                            switch (input3)
                            {
                                case "onivoro":
                                    Console.WriteLine("homem");
                                    break;

                                case "herbivoro":
                                    Console.WriteLine("vaca");
                                    break;
                            }
                            break;
                    }
                    break;

                case "invertebrado":
                    switch (input2)
                    {
                        case "inseto":
                            switch (input3)
                            {
                                case "hematofago":
                                    Console.WriteLine("pulga");
                                    break;

                                case "herbivoro":
                                    Console.WriteLine("lagarta");
                                    break;
                            }
                            break;
                        case "anelideo":
                            switch (input3)
                            {
                                case "hematofago":
                                    Console.WriteLine("sanguessuga");
                                    break;

                                case "onivoro":
                                    Console.WriteLine("minhoca");
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
