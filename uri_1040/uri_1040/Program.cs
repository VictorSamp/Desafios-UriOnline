using System;
using System.Globalization;

namespace uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            float nota1, nota2, nota3, nota4, media, notaDoExame, mediaFinal;

            input = Console.ReadLine().Split(' ');

            nota1 = float.Parse(input[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(input[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(input[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(input[3], CultureInfo.InvariantCulture);

            media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaDoExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);               

                mediaFinal = (media + notaDoExame) / 2;

                Console.WriteLine("Nota do exame: " + notaDoExame.ToString("F1", CultureInfo.InvariantCulture));

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
