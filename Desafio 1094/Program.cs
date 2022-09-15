using System;
using System.Globalization;
namespace Desafio_1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            int somac = 0;
            int somar = 0;
            int somas = 0;
            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int qd = int.Parse(vet[0]);
                string tipo = (vet[1]);
                soma = soma + qd;
                if (tipo == "C")
                {
                    somac = somac + qd;
                }
                else if (tipo == "R")
                {
                    somar = somar + qd;
                }
                else if (tipo == "S")
                {
                    somas = somas + qd;
                }
            }
            double pc = somac * 100 / (double)soma;
            double pr = somar * 100 / (double)soma;
            double ps = somas * 100 / (double)soma;

            Console.WriteLine("Total: " + soma + " cobaias");
            Console.WriteLine("Total de coelhos: " + somac);
            Console.WriteLine("Total de ratos: " + somar);
            Console.WriteLine("Total de sapos: " + somas);
            Console.WriteLine("Percentual de coelhos: " + pc.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + pr.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + ps.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
