using System;
using System.Numerics;

namespace FactorialNew
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorialNumber = int.Parse(Console.ReadLine());

            FindFactorial(factorialNumber);
        }

        private static void FindFactorial(int factorialNumber)
        {
            BigInteger number = 1;

            do
            {
                number = number * factorialNumber;
                factorialNumber--;
            } while (factorialNumber > 1);
            Console.WriteLine(number);
        }
    }
}
