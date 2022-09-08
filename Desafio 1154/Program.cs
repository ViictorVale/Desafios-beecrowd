using System;
using System.Globalization;
namespace Desafio_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, qd;
            idade = int.Parse(Console.ReadLine());
            soma = 0;
            qd = 0;

            while (idade > 0)
            {
                qd = qd + 1;
                soma = soma + idade;
                idade = int.Parse(Console.ReadLine());
            }
            double media = soma / qd;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
