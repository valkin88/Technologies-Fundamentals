using System;
using System.Linq;
using System.Collections.Generic;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> firstPartOfArrayList = new List<int>(arrayOfNumbers);
            List<int> secondPartOfArrayList = new List<int>(arrayOfNumbers);
           

            int counterOfArrayLists = (arrayOfNumbers.Count / 2) / 2;

            firstPartOfArrayList.RemoveRange(counterOfArrayLists, counterOfArrayLists * 3);
            firstPartOfArrayList.Reverse();
            secondPartOfArrayList.RemoveRange(0, counterOfArrayLists * 3);
            secondPartOfArrayList.Reverse();
            List<int> sumOfTwoArrays = new List<int>();

            for (int i = 0; i < secondPartOfArrayList.Count; i++)
            {
                firstPartOfArrayList.Add(secondPartOfArrayList[i]);
            }

            arrayOfNumbers.RemoveRange((counterOfArrayLists * 2) + counterOfArrayLists, counterOfArrayLists);
            arrayOfNumbers.RemoveRange(0, counterOfArrayLists);

            for (int i = 0; i < arrayOfNumbers.Count; i++)
            {
                sumOfTwoArrays.Add(firstPartOfArrayList[i] + arrayOfNumbers[i]);
              
            }

            Console.WriteLine(string.Join(" ", sumOfTwoArrays));
        }
    }
}
