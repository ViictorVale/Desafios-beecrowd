using System;

namespace Exer1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, a, b, c, d;

            idade = int.Parse(Console.ReadLine());

            a = idade / 365;
            b = idade % 365;
            c = b / 30;
            d = b % 30;


            Console.WriteLine(a + " ano(s)");
            Console.WriteLine(c + " mes(es)");
            Console.WriteLine(d + " dia(s)");

        }
    }
}
