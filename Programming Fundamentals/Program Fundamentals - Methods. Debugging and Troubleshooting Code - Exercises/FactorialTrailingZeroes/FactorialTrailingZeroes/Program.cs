using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {

        static int factorialNumber = int.Parse(Console.ReadLine());

        static void Main(string[] args)
        {
            CountZeroesOfFactorial();
        }

        static BigInteger FindFactorial(int factorialNumber)
        {
            BigInteger number = 1;
            BigInteger numberFactorial = 0;

            do
            {
                number = number * factorialNumber;
                factorialNumber--;
            } while (factorialNumber > 1);
            numberFactorial = number;
            return numberFactorial;
        }

        static void CountZeroesOfFactorial()
        {
            int countOfZeroes = 0;
            BigInteger zeroes = 0;
            BigInteger numberAfterDeviding = 0;

            BigInteger numberOfFactorial = FindFactorial(factorialNumber);

            do
            {
                zeroes = numberOfFactorial % 10;
                if (zeroes != 0)
                {
                    break;
                }
                else
                {
                    countOfZeroes++;
                }

                numberOfFactorial = numberOfFactorial / 10;
            } while (zeroes == 0);

            Console.WriteLine(countOfZeroes);

        }
    }
}
