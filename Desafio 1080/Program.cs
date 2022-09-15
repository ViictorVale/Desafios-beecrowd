using System;

namespace Desafio_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;
            for (int i = 2; i <= 100; i++)
            {
                int valores = int.Parse(Console.ReadLine());
                if (valores > maior)
                {
                    maior = valores;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
