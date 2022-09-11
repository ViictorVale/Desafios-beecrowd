using System;

namespace Desafio_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int novogrenal = 1;
            int qd = 0;
            int wininter = 0;
            int wingremio = 0;
            int empates = 0;
            while (novogrenal == 1)
            {
                qd = qd + 1;
                string[] gols = Console.ReadLine().Split(' ');
                int inter = int.Parse(gols[0]);
                int gremio = int.Parse(gols[1]);

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novogrenal = int.Parse(Console.ReadLine());

                if (inter > gremio)
                {
                    wininter = wininter + 1;
                }
                else if (gremio > inter)
                {
                    wingremio = wingremio + 1;
                }
                else
                {
                    empates = empates + 1;
                }
                while (novogrenal != 1 && novogrenal != 2)
                {
                    novogrenal = int.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine(qd + " grenais");
            Console.WriteLine("Inter:" + wininter);
            Console.WriteLine("Gremio:" + wingremio);
            Console.WriteLine("Empates:" + empates);

            if (wininter > wingremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (wingremio > wininter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
