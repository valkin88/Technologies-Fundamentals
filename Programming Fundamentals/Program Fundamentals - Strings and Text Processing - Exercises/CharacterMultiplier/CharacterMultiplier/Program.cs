using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string firstString = input[0].ToString();
            string secondString = input[1].ToString();

            int sum = 0;

            if (firstString.Length < secondString.Length)
            {
                sum = SumOfChars(secondString, firstString, sum);
            }
            else if (firstString.Length > secondString.Length)
            {
                sum = SumOfChars(firstString, secondString, sum);
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    char letterOfFirstString = firstString[i];
                    char letterOfSecondString = secondString[i];
                    sum += (letterOfFirstString * letterOfSecondString);
                }
            }
            Console.WriteLine(sum);
        }

        public static int SumOfChars(string secondString, string firstString, int sum)
        {
            int counter = firstString.Length;
            int index = 0;
            while (true)
            {
                if (counter == 0)
                {
                    for (int i = index; i < secondString.Length; i++)
                    {
                        sum += secondString[i];
                    }
                    break;
                }
                char letterOfFirstString = firstString[index];
                char letterOfSecondString = secondString[index];
                sum += (letterOfFirstString * letterOfSecondString);
                index++;
                counter--;
            }
            return sum;
        }
    }
}
