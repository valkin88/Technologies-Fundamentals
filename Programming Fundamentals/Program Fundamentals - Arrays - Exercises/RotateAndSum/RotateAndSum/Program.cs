using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int countOfRotations = int.Parse(Console.ReadLine());

            int[] copyOfArrayOfIntegers = new int[arrayOfIntegers.Length];

            int increaserOfArray = 0;
            for (int rotation = 0; rotation < arrayOfIntegers.Length; rotation++)
            {
                copyOfArrayOfIntegers[rotation] = arrayOfIntegers[increaserOfArray];
                increaserOfArray++;
            }


            int[] finalArrayAfterSum = new int[copyOfArrayOfIntegers.Length];

            for (int i = 0; i < countOfRotations; i++)
            {
                int lastNumberOfArray = copyOfArrayOfIntegers[copyOfArrayOfIntegers.Length - 1];
                for (int k = copyOfArrayOfIntegers.Length - 1; k >= 1; k--)
                {
                    copyOfArrayOfIntegers[k] = copyOfArrayOfIntegers[k - 1];
                }
                copyOfArrayOfIntegers[0] = lastNumberOfArray;

                increaserOfArray = 0;

                for (int j = 0; j < copyOfArrayOfIntegers.Length; j++)
                {
                    finalArrayAfterSum[j] += copyOfArrayOfIntegers[increaserOfArray];
                    increaserOfArray++;
                }

            }
            Console.WriteLine(string.Join(" ", finalArrayAfterSum));
        }
    }
}
