using System;

namespace Desafio_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int calc = i * i;
                    Console.WriteLine(i + "^2 = " + calc);
                }
            }
        }
    }
}
