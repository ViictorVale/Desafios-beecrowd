using System;
using System.Globalization;

namespace Exer1010
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1, c2, vap;

            string[] vet1 = Console.ReadLine().Split(' ');
            int cp1 = int.Parse(vet1[0]);
            int np1 = int.Parse(vet1[1]);
            double vu1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int cp2 = int.Parse(vet2[0]);
            int np2 = int.Parse(vet2[1]);
            double vu2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            c1 = np1 * vu1;
            c2 = np2 * vu2;
            vap = c1 + c2;

            Console.WriteLine("VALOR A PAGAR: R$ " + vap.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
