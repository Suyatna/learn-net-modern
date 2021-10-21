using System;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 8;
            int denominator = 3;

            try
            {
                int divideByZero = input / denominator;

                System.Console.WriteLine(divideByZero);
            }
            catch (FormatException) 
            {
                System.Console.WriteLine("input and denominator is int");
            }
            catch (System.Exception)
            {               
                System.Console.WriteLine("denominator shouldn't value by zero!");
            }
        }
    }
}
