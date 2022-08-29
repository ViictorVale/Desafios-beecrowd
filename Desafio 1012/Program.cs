using System;
using System.Globalization;

namespace Exer1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double q1, q2, q3, q4, q5, pc;

            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            pc = Math.Pow(C, 2.0);
            q4 = Math.Pow(B, 2.0);

            q1 = (A * C) / 2;
            q2 = pc * 3.14159;
            q3 = ((A + B) * C) / 2;
            q5 = A * B;

            Console.WriteLine("TRIANGULO: " + q1.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + q2.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + q3.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + q4.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + q5.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
