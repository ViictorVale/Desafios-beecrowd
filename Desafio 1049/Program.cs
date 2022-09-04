using System;

namespace Desafio_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string filo = Console.ReadLine();
            string classe = Console.ReadLine();
            string dieta = Console.ReadLine();

            if (filo == "vertebrado")
            {
                if ( classe == "ave")
                {
                   if (dieta == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                   else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (dieta == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (classe == "inseto")
                {
                    if (dieta == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (dieta == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
