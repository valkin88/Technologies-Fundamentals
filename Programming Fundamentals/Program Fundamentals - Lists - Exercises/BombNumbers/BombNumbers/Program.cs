using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listOfSpecialNumberAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int specialNumber = listOfSpecialNumberAndPower[0];
            int powerOfSpecialNumber = listOfSpecialNumberAndPower[1];

            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] == specialNumber)
                {
                    int leftSideOfList = Math.Max(i - powerOfSpecialNumber, 0);

                    int rightSideOfList = Math.Min(i + powerOfSpecialNumber, listOfIntegers.Count - 1);

                    int lenghtOfNumbersToRemove = rightSideOfList - leftSideOfList + 1;
                    listOfIntegers.RemoveRange(leftSideOfList, lenghtOfNumbersToRemove);
                    i = 0;
                }
            }
            Console.WriteLine(listOfIntegers.Sum());
        }
    }
}
