using System;

namespace Exer1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, vm, mult;
            double gc;

            t = int.Parse(Console.ReadLine());
            vm = int.Parse(Console.ReadLine());

            mult = t * vm;

            gc = (double)mult / 12;

            Console.WriteLine(gc.ToString("F3"));
        }
    }
}
