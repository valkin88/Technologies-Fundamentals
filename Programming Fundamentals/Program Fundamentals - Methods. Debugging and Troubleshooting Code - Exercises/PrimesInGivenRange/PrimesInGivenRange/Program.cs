using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class Program
    {

        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long lastNumber = long.Parse(Console.ReadLine());
            long counter = 0;

            ReturnListOfPrimeNumbersInRange(firstNumber, lastNumber, counter);
            

        }

        private static void ReturnListOfPrimeNumbersInRange(long firstNumber, long lastNumber, long counter)
        {
            var primes = new List<long>();
            string newStr = "";
            if (firstNumber < 0 || lastNumber < 0)
            {
                firstNumber = 2;
            }
            if (firstNumber == 0 || lastNumber == 1)
            {
                firstNumber = 2;
            }
            if (firstNumber > lastNumber)
            {
                Console.WriteLine("empty list");
            }

            for (long i = firstNumber; i <= lastNumber; i++)
            {

                for (long j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                    if (counter > 2)
                    {
                        break;
                    }
                }
                if (counter <= 2)
                {
                    primes.Add(i);
                }
                counter = 0;

            }
            foreach (var prime in primes)
            {
                newStr += prime + ", ";
            }
            newStr = newStr.Remove(newStr.Length - 2);
            Console.WriteLine(newStr);
        }
    }
}
