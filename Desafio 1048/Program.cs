using System;
using System.Globalization;
namespace Exer1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400)
                ExibirDados(0.15, salario);
            else if (salario == 400.01 || salario <= 800)
                ExibirDados(0.12, salario);
            else if (salario == 800.01 || salario <= 1200)
                ExibirDados(0.10, salario);
            else if (salario == 1200.01 || salario <= 2000)
                ExibirDados(0.07, salario);
            else
                ExibirDados(0.04, salario);
        }

        static void ExibirDados(double percentual, double salario)
        {
            var calculo = salario * percentual;
            var resultado = salario + calculo;

            Console.WriteLine("Novo salario: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + calculo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"Em percentual: {percentual * 100} %");
        }
    }
}
