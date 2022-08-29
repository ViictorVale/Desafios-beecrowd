using System;
using System.Globalization;

namespace Exer1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, media, M1, M2, soma;
            double p1 = 3.5;
            double p2 = 7.5;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            M1 = A * p1;
            M2 = B * p2;
            soma = M1 + M2;
            media = soma / (p1 + p2);

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));





        }
    }
}
