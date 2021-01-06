using System;

namespace uri_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int horaInicial, minutoInicial, horaFinal, minutoFinal, instanteInicial, instanteFinal, duracao, duracaoHoras, duracaoMinutos;
            
            input = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(input[0]);
            minutoInicial = int.Parse(input[1]);
            horaFinal = int.Parse(input[2]);
            minutoFinal = int.Parse(input[3]);

            instanteInicial = horaInicial * 60 + minutoInicial;
            instanteFinal = horaFinal * 60 + minutoFinal;

            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            duracaoHoras = duracao / 60;
            duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}
