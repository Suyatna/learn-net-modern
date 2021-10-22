using System;

namespace Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a number between 0 and 255: ");    
            string inputNumber = Console.ReadLine();

            System.Console.Write("Enter another number between 0 and 255: ");
            string inputAnotherNumber = Console.ReadLine();

            try
            {
                int value = int.Parse(inputNumber) / int.Parse(inputAnotherNumber);

                System.Console.WriteLine($"{inputNumber} divided by {inputAnotherNumber} is {value}");
            }
            catch (FormatException)
            {
                System.Console.WriteLine("FormatException: Input string was not in a corrent format.");        
            }
        }
    }
}
