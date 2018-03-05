using System;
using System.Linq;
using System.Collections.Generic;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var secondArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (firstArray.Length >= secondArray.Length)
            {
                SearchingFromTheLeftOrFromTheRight(firstArray, secondArray);
            }
            else
            {
                SearchingFromTheLeftOrFromTheRight(secondArray, firstArray);
            }


        }

        static void ScaningArraysFromTheLeft(string[] arr1, string[] arr2)
        {
            int counter = 0;
            int increaserOfArray = 0;
            for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr2[j] == arr1[increaserOfArray])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                    increaserOfArray++;

                }
                Console.WriteLine(counter);
        }

        static void ScaningArraysFromTheRight(string[] arr1, string[] arr2)
        {
            int decreaserOfArray = arr1.Length - 1;
            int counter = 0;
            for (int j = arr2.Length - 1; j >= 0; j--)
            {

                if (arr2[j] == arr1[decreaserOfArray])
                {
                    counter++;
                }
                else
                {
                    break;
                }
                decreaserOfArray--;

            }
            Console.WriteLine(counter);
        }

        static void SearchingFromTheLeftOrFromTheRight(string[] arr1, string[] arr2)
        {
            int counter = 0;
            if (arr1[0] == arr2[0])
            {
                ScaningArraysFromTheLeft(arr1, arr2);
            }
            else if (arr1[arr1.Length - 1] == arr2[arr2.Length - 1])
            {
                ScaningArraysFromTheRight(arr1, arr2);
            }
            else
            {
                Console.WriteLine(counter);
            }
        }
    }
}
