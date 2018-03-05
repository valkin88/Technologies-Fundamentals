using System;

namespace MaxMethod
{
    class Program
    {
        static int firstNumber = int.Parse(Console.ReadLine());

        static int secondNumber = int.Parse(Console.ReadLine());

        static int thirdNumber = int.Parse(Console.ReadLine());

        static int maxNumber = 0;

        static void GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                maxNumber = firstNumber;
            }
            else
            {
                maxNumber = secondNumber;
            }
        }

        static void Main(string[] args)
        {
            GetMax(firstNumber, secondNumber);
            if (thirdNumber >= maxNumber)
            {
                maxNumber = thirdNumber;
                Console.WriteLine(maxNumber);
            }
            else
            {
                Console.WriteLine(maxNumber);
            }

        }
    }
}
