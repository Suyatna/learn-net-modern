using System;

namespace Excercise05
{
    static class Program
    {
        static void Main(string[] args)
        {
            // // 1.
            int x = 3;
            int y = 2 + ++x;
            Console.WriteLine($"x: {x}, y: {y}");

            Console.WriteLine();
            
            // 2.
            x = 3 << 2;
            y = 10 >> 1;
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}