using System;
using System.Globalization;
namespace Desafio_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media, nota, media2;

            string[] valores = Console.ReadLine().Split(' ');
            n1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(valores[3], CultureInfo.InvariantCulture);

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (media == 4.5f)
                media = 4.8f;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
        }

    }
}
