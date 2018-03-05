using System;
using System.Collections.Generic;

namespace Masteriber
{
    class Program
    {
        static long lastNumberToCheck = long.Parse(Console.ReadLine());

        static void Main(string[] args)
        {

            foreach (var number in CreatingListOfSumOfDigitsDevidedBySeven())
            {
                long num = number;
                long digit = 0;
                while (num > 0)
                {
                    digit = num % 10;
                    num = num / 10;

                    if (digit % 2 == 0)
                    {
                        Console.WriteLine(number);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                    
            }
        }

        static List<long> CreateAListOfPalindromeNumbers()
        {
            List<long> listOfPalindromeNumbers = new List<long>();
            for (long i = 1; i <= lastNumberToCheck; i++)
            {
                long numberToCheck = i;
                long num = numberToCheck;
                long digit = 0;
                long reverseNumber = 0;

                while (num > 0)
                {
                    digit = num % 10;
                    reverseNumber = reverseNumber * 10 + digit;
                    num = num / 10;
                }

                if (numberToCheck == reverseNumber)
                {
                    listOfPalindromeNumbers.Add(numberToCheck);
                }
                else
                {
                    continue;
                }

            }
            return listOfPalindromeNumbers;
        }

        static List<long> CreatingListOfSumOfDigitsDevidedBySeven()
        {
            List<long> listOfPalindromeNumbersDevidedBySeven = new List<long>();
            foreach (var number in CreateAListOfPalindromeNumbers())
            {
                long sumOfDigits = 0;
                long num = number;
                long digit = 0;
                while (num > 0)
                {
                    digit = num % 10;
                    sumOfDigits = sumOfDigits + digit;
                    num = num / 10;
                }
                if (sumOfDigits % 7 == 0)
                {
                    listOfPalindromeNumbersDevidedBySeven.Add(number);
                }
                else
                {
                    continue;
                }
            }
            return listOfPalindromeNumbersDevidedBySeven;
        }
    }
}
