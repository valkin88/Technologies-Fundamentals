using System;
using System.Linq;
using System.IO;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
         {
            string input = File.ReadAllText("Input.txt");
            var arrayOfIntegers = input
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();
            File.Delete("output.txt");
            bool result = false;
            int index = 0;
            if (arrayOfIntegers.Length == 1)
            {
                index = 0;
                File.WriteAllText("output.txt", Convert.ToString(index));
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
                        index = i;
                        File.WriteAllText("output.txt", Convert.ToString(index));
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
                    File.WriteAllText("output.txt", "no");
                }


            }

        }
    }
}
