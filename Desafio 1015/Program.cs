using System;
using System.Globalization;

namespace Exer1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double sub1, sub2, p1, p2, soma, raiz;
            string[] vet1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            sub1 = x2 - x1;
            sub2 = y2 - y1;

            p1 = Math.Pow(sub1, 2.0);
            p2 = Math.Pow(sub2, 2.0);

            soma = p1 + p2;

            raiz = Math.Sqrt(soma);

            Console.WriteLine(raiz.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
