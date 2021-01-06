using System;

namespace uri_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int horaInicial, horaFinal, duracao;

            input = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(input[0]);
            horaFinal = int.Parse(input[1]);

            if (horaInicial == horaFinal)
            {
                duracao = 24;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            } else if (horaInicial > horaFinal){
                duracao = (24 - horaInicial) + horaFinal;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            } else
            {
                duracao = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
        }
    }
}
