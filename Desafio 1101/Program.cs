using System;

namespace Desafio_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int m = int.Parse(num[0]);
            int n = int.Parse(num[1]);
            while (m > 0 && n > 0)
            {

                if (m > n)
                {
                    int aux = m;
                    m = n;
                    n = aux;

                }
                int soma = 0;
                for (int i = m; i <= n; i++)
                {
                    soma = soma + i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + soma);
                num = Console.ReadLine().Split(' ');
                m = int.Parse(num[0]);
                n = int.Parse(num[1]);
            }

        }
    }
}
