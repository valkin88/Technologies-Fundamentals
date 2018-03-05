using System;
using System.Collections.Generic;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int maxCounter = 0;

            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                int counter = 0;
                for (int j = i + 1; j < listOfNumbers.Length; j++)
                {
                    if (Math.Abs(listOfNumbers[i] - listOfNumbers[j]) == difference)
                    {
                        counter++;
                    }
                }
                maxCounter += counter;
            }
            Console.WriteLine(maxCounter);
        }
    }
}
