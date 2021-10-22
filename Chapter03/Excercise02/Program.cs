using System;
using static System.Console;

namespace Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                WriteLine(i);

                if (i == byte.MaxValue)
                {
                    return;
                }
            }
            
        }
    }
}
