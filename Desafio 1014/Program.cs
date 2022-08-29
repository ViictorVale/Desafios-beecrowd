using System;
using System.Globalization;

namespace Exer1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, cmed;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cmed = x / y;

            Console.WriteLine(cmed.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
