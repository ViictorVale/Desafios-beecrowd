using System;
using System.Globalization;

namespace Desafio_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                double calc = (v1 * 2.0 + v2 * 3.0 + v3 * 5.0) / 10;
                Console.WriteLine(calc.ToString("F1", CultureInfo.InvariantCulture));
                
            }
        }
    }
}
