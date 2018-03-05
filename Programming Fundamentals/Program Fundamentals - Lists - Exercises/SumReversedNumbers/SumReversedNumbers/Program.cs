using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sumOfAllNumbersFromTheList = 0;


            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                int number = listOfIntegers[i];
                string numberConvertedInToString = number.ToString();
                char[] numberConvertedInToChar = numberConvertedInToString.ToCharArray();
                Array.Reverse(numberConvertedInToChar);
                string reversedValue = new string(numberConvertedInToChar);
                int reversedInt = int.Parse(reversedValue);

                sumOfAllNumbersFromTheList += reversedInt;

                number = 0;
            }

            Console.WriteLine(sumOfAllNumbersFromTheList);
        }
    }
}
