using System;

namespace Exer1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, a, b, c, d, e, f, g, h, i, j, k, l, m, n;

            N = int.Parse(Console.ReadLine());

            a = N / 100;
            b = N % 100;
            c = b / 50;
            d = b % 50;
            e = d / 20;
            f = d % 20;
            g = f / 10;
            h = f % 10;
            i = h / 5;
            j = h % 5;
            k = j / 2;
            l = j % 2;
            m = l / 1;
            n = l % 1;

            Console.WriteLine(N);
            Console.WriteLine(a + " nota(s) de R$ 100,00");
            Console.WriteLine(c + " nota(s) de R$ 50,00");
            Console.WriteLine(e + " nota(s) de R$ 20,00");
            Console.WriteLine(g + " nota(s) de R$ 10,00");
            Console.WriteLine(i + " nota(s) de R$ 5,00");
            Console.WriteLine(k + " nota(s) de R$ 2,00");
            Console.WriteLine(m + " nota(s) de R$ 1,00");

        }
    }
}
