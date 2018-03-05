using System;

namespace FibonacciNumbers
{
    class Program
    { 
        static void Main(string[] args)
        {
            int editedNumber = int.Parse(Console.ReadLine());
            FindingFibonacciNumber(editedNumber);
        }

        static int FindingFibonacciNumber(int editedNumber)
        {
            int result = 0;
            int f0 = 1;
            int f1 = 1;
            for (int i = 0; i < editedNumber - 1; i++)
            {
                int fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            result = f1;
            Console.WriteLine(result);

            return result;
        }
    }
}
