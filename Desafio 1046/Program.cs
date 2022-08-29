using System;

namespace Exer1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int hi, hf, h1;

            string[] vet = Console.ReadLine().Split(' ');
            hi = int.Parse(vet[0]);
            hf = int.Parse(vet[1]);

            if (hi > hf)
            {
                h1 = 24 - (hi - hf);
            }
            else if (hf > hi)
            {
                h1 = hf - hi;
            }
            else
            {
                h1 = 24;
            }

            Console.WriteLine("O JOGO DUROU " + h1 + " HORA(S)");


        }
    }
}
