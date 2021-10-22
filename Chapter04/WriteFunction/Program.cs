using System;
using static System.Console;

namespace WriteFunction
{
    class Program
    {
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");

            for (int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }

            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;

            do
            {
                Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }

            } while (isNumber);
        }

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;

            switch (twoLetterRegionCode)
            {
                case "CH": // switzerland
                    rate = 0.08M;
                    break;
                case "DK": // denmark
                case "NO": // norway
                    rate = 0.25M;
                    break;
                case "GB": // united kingdom
                case "FR": // france
                    rate = 0.2M;
                    break;
                case "HU": // hungary
                    rate = 0.27M;
                    break;
                case "OR": // oregon
                case "AK": // alaska
                case "MT": // montana
                    rate = 0.0M;
                    break;
                case "ND": // north dakota
                case "WI": // wisconsin
                case "ME": // maryland
                case "VA": // virginia
                    rate = 0.05M;
                    break;
                case "CA": // california
                    rate = 0.0825M;
                    break;
                default: // most US states
                    rate = 0.06M;
                    break;
            }

            return amount * rate;
        }

        static void RunCalculatorTax()
        {
            Write("Enter a mount: ");
            string amountInText = ReadLine();

            Write("Enter a two-letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay {taxToPay} in sales tax.");
            }
            else
            {
                WriteLine("You did not enter a valid amount!");
            }
        }

        static void Main(string[] args)
        {
            // RunTimesTable();
            RunCalculatorTax();
        }
    }
}
