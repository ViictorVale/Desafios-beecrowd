using System;
using System.Globalization;

namespace Exer1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio, A;
            double n = 3.14159;


            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = Math.Pow(raio, 2.0);

            area = A * n;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
