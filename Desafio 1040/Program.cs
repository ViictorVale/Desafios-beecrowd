using System;
using System.Globalization;
namespace Desafio_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, nota,
                p1 = 2, p2 = 3, p3 = 4, p4 = 1,
                m1, m2, m3, m4,
                media, media2, soma;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);
            
            m1 = n1 * p1;
            m2 = n2 * p2;
            m3 = n3 * p3;
            m4 = n4 * p4;
            soma = m1 + m2 + m3 + m4;
            media = soma / (p1 + p2 + p3 + p4);
            

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media == 5.0 && media <= 6.9)
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media2 = (nota + media) / 2;
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame:" + nota.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Media final: " + media2.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media2 = (nota + media) / 2;
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame:" + nota.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Media final: " + media2.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

    }
}
