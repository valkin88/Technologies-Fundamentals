using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCounter = 0;
            string stringOfNumbersInSubsequence = "";
            string saveOfSubsequence = "";

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                int counter = 0;
                stringOfNumbersInSubsequence += arrayOfIntegers[i];
                int index = i;
                for (int j = i + 1; j < arrayOfIntegers.Length; j++)
                {
                    if (arrayOfIntegers[index] < arrayOfIntegers[j])
                    {
                        counter++;
                        stringOfNumbersInSubsequence += " " + arrayOfIntegers[j];
                    }
                    else
                    {
                        break;
                    }
                    index++;
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    saveOfSubsequence = stringOfNumbersInSubsequence;
                }
                stringOfNumbersInSubsequence = "";
            }
            Console.WriteLine(saveOfSubsequence);
        }
    }
}
