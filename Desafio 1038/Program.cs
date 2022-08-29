using System;
using System.Globalization;

namespace Exer1038_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, qd;
            int item;

            string[] vet = Console.ReadLine().Split(' ');
            item = int.Parse(vet[0]);
            qd = double.Parse(vet[1]);

            if (item == 1)
            {
                preco = qd * 4.0;
            }
            else if (item == 2)
            {
                preco = qd * 4.50;
            }
            else if (item == 3)
            {
                preco = qd * 5.0;
            }
            else if (item == 4)
            {
                preco = qd * 2.0;
            }
            else if (item == 1.50)
            {
                preco = qd * 1.50;
            }
            else
            {
                preco = 0;
            }

            Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
