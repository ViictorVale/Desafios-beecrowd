using System;
using System.Globalization;

namespace Exer1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nh;
            double vh, s;

            n = int.Parse(Console.ReadLine());
            nh = int.Parse(Console.ReadLine());
            vh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            s = nh * vh;

            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + s.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
