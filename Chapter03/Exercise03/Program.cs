﻿using System;

namespace Excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Game!");
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {               
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write($"FizzBuzz, ");
                }
                else if (i % 3 == 0) 
                {
                    Console.Write($"Fizz, ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write($"Buzz, ");
                }
                else
                {
                    Console.Write($"{i}, ");
                } 
                
                if (i % 10 == 0)
                {
                    Console.Write($"\n");
                }              
            }
        }
    }
}
