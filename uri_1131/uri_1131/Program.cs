using System;

namespace uri_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoUsuario = 0;
            string[] entradaGols;
            int golsInter, golsGremio;
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int quantidadeJogos = 0;

            while (opcaoUsuario != 2)
            {
                entradaGols = Console.ReadLine().Split(' ');

                golsInter = int.Parse(entradaGols[0]);
                golsGremio = int.Parse(entradaGols[1]);

                quantidadeJogos++;

                if (golsInter > golsGremio)
                {
                    vitoriasInter++;
                }
                else if (golsGremio > golsInter)
                {
                    vitoriasGremio++;
                }
                else
                {
                    empates++;

                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcaoUsuario = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0} grenais", quantidadeJogos);
            Console.WriteLine("Inter:{0}", vitoriasInter);
            Console.WriteLine("Gremio:{0}", vitoriasGremio);
            Console.WriteLine("Empates:{0}", empates);

            if ( vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            } else if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
        }
    }
}
