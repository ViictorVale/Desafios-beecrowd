using System;

namespace Desafio_1047
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] tempo = Console.ReadLine().Split(' ');
            int hi = int.Parse(tempo[0]);
            int mi = int.Parse(tempo[1]);
            int hf = int.Parse(tempo[2]);
            int mf = int.Parse(tempo[3]);

            int instanteInicial = hi * 60 + mi;
            int instanteFinal = hf * 60 + mf;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }
            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTOS(S)");
        }
    }
}
