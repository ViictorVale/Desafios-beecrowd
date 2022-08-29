using System;

namespace Exer1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, soma1, soma2;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            soma1 = a + b;
            soma2 = c + d;

            if (b > c && d > a && soma2 > soma1 && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
