using System;
using System.Globalization;
namespace Desafio_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3,
                 a, b, c;

            string[] valores = Console.ReadLine().Split(' ');
            n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (n1 > n2 && n1 > n3)
                a = n1;
                if (n2 > n3)
                {

                }
            }
        }
    }
}
