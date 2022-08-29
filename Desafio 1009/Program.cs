using System;
using System.Globalization;

namespace Exer1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double sf, tdv, total;

            nome = (Console.ReadLine());
            sf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tdv = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = tdv * 0.15 + sf;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
