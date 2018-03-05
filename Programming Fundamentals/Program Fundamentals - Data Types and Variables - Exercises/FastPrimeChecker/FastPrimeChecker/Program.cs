using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber  = int.Parse(Console.ReadLine());

            for (int numberToCheck  = 2; numberToCheck <= lastNumber; numberToCheck++)
            {
                bool isPrime = true;
                for (int devider = 2; devider <= Math.Sqrt(numberToCheck); devider++)
                {
                    if (numberToCheck % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{numberToCheck} -> {isPrime}");
            }
        }
    }
}
