using System;
using System.Globalization;

namespace Exer1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double qd, preco;
            int codigo;


            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            qd = double.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    preco = qd * 4.0;
                    break;
                case 2:
                    preco = qd * 4.50;
                    break;
                case 3:
                    preco = qd * 5.0;
                    break;
                case 4:
                    preco = qd * 2.0;
                    break;
                default:
                    preco = qd * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
