using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numbersInRageToTake = arrayOfNumbers[0];
            int numbersInRageToRemove = arrayOfNumbers[1];
            int numberInListThatContainsIt = arrayOfNumbers[2];

            listOfIntegers.RemoveRange(numbersInRageToTake, listOfIntegers.Count - numbersInRageToTake);
            listOfIntegers.RemoveRange(0, numbersInRageToRemove);

            if (listOfIntegers.Contains(numberInListThatContainsIt))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
