using System;
using System.Globalization;
namespace Exer1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, A;
            int na, nb, nc, nd, ne, nf, ng, nh, ni, nj, nk, nl,
                ma, mb, mc, md, mf, mg, mh, mi, mj, mk, valor1, B;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valor1 = (int)valor;

            na = valor1 / 100;
            nb = valor1 % 100;
            nc = nb / 50;
            nd = nb % 50;
            ne = nd / 20;
            nf = nd % 20;
            ng = nf / 10;
            nh = nf % 10;
            ni = nh / 5;
            nj = nh % 5;
            nk = nj / 2;
            nl = nj % 2;

            A = valor * 100;
            B = (int)A;
            ma = B % 100;
            mb = ma / 50;
            mc = ma % 50;
            md = mc / 25;
            mf = mc % 25;
            mg = mf / 10;
            mh = mf % 10;
            mi = mh / 5;
            mj = mh % 5;
            mk = mj / 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(na + " nota(s) de R$ 100.00");
            Console.WriteLine(nc + " nota(s) de R$ 50.00");
            Console.WriteLine(ne + " nota(s) de R$ 20.00");
            Console.WriteLine(ng + " nota(s) de R$ 10.00");
            Console.WriteLine(ni + " nota(s) de R$ 5.00");
            Console.WriteLine(nk + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(nl + " moeda(s) de R$ 1.00");
            Console.WriteLine(mb + " moeda(s) de R$ 0.50");
            Console.WriteLine(md + " moeda(s) de R$ 0.25");
            Console.WriteLine(mg + " moeda(s) de R$ 0.10");
            Console.WriteLine(mi + " moeda(s) de R$ 0.05");
            Console.WriteLine(mk + " moeda(s) de R$ 0.01");

        }
    }
}
