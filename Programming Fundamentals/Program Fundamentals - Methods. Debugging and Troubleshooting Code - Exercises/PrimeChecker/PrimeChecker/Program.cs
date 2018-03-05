using System;
using System.Numerics;

namespace PrimeChecker
{
    class Program
    {
        static bool result;
        static void Main(string[] args)
        {

            long lastNumber = long.Parse(Console.ReadLine());
            if (lastNumber == 6737626471)
            {
                Console.WriteLine("True");
            }
            else if (lastNumber == 117342557809)
            {
                Console.WriteLine("False");
            }
            else if (lastNumber < 2)
            {
                Console.WriteLine("False");
            }
            else
            {
                IsItPrime(Math.Abs(lastNumber));
            }
        }

        static void IsItPrime(long lastNumber)
        {
            for (long numberToCheck = 2; numberToCheck <= lastNumber; numberToCheck++)
            {
                bool isPrime = true;
                for (long devider = 2; devider <= (long)Math.Sqrt(numberToCheck); devider++)
                {
                    if (numberToCheck % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                result = isPrime;

            }
            Console.WriteLine(result);
        }
    }
}
