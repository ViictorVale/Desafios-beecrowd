﻿using System;

namespace Desafio_1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if(i % n == 2)
               
                Console.WriteLine(i);
                
            }
        }
    }
}
