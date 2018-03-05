using System;
using System.Collections.Generic;
using System.Linq;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long lastNumber = long.Parse(Console.ReadLine());
            long counter = 0;

            if (lastNumber >= 2)
            {
                IsItPrime(lastNumber, counter);
            }
        }


        static void IsItPrime(long lastNumber, long counter)
        {
            List<long> listOfPrimeNumbers = new List<long>();
            string newStr = "";
            for (long numberToCheck = 2; numberToCheck <= lastNumber; numberToCheck++)
            {

                for (long devider = 1; devider <= numberToCheck; devider++)
                {
                    if (numberToCheck % devider == 0)
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
                    listOfPrimeNumbers.Add(numberToCheck);
                }
                counter = 0;

            }
            foreach (var prime in listOfPrimeNumbers)
            {
                newStr += prime + " ";
            }
            newStr = newStr.Remove(newStr.Length - 1);
            Console.WriteLine(newStr);
        }
    }
}
