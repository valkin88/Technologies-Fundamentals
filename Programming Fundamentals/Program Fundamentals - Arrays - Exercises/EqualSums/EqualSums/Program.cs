using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
         {
            var arrayOfIntegers = Console
                                 .ReadLine()
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();
            bool result = false;

            if (arrayOfIntegers.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                int sumOfLeftSide = 0;
                int sumOfRightSide = 0;
                for (int i = 0; i < arrayOfIntegers.Length; i++)
                {
                    for (int leftIndex = 0; leftIndex < i; leftIndex++)
                    {
                        sumOfLeftSide += arrayOfIntegers[leftIndex];
                    }

                    for (int rightIndex = i + 1; rightIndex < arrayOfIntegers.Length; rightIndex++)
                    {
                        sumOfRightSide += arrayOfIntegers[rightIndex];
                    }

                    if (sumOfLeftSide == sumOfRightSide)
                    {
                        Console.WriteLine(i);
                        result = true;
                    }
                    else
                    {
                        sumOfLeftSide = 0;
                        sumOfRightSide = 0;
                    }
                }
                if (result == false)
                {
                    Console.WriteLine("no");
                }


            }

        }
    }
}
