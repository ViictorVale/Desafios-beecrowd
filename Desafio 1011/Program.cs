using System;
using System.Globalization;

namespace Exer1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, volume, A;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = Math.Pow(r, 3.0);

            volume = (4 / 3.0) * (3.14159 * A);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
