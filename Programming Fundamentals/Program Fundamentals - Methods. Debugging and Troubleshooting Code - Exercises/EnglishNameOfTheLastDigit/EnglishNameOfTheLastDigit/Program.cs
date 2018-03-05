using System;
using System.Numerics;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static long printedInteger = long.Parse(Console.ReadLine());
        static long lastDigit;

        static void PrintingEnglishWordOfADigit()
        {
            lastDigit = printedInteger % 10;
            switch (Math.Abs(lastDigit))
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                case 0: Console.WriteLine("zero"); break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            PrintingEnglishWordOfADigit();
        }
    }
}
