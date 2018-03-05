using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequencOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> listOfEqualDigits = new List<int>();

            int maxCounter = 0;
            int numberOfMaxSequal = 0;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                int counter = 0;
                for (int j = i + 1; j < listOfNumbers.Count; j++)
                {
                    if (listOfNumbers[i] == listOfNumbers[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    numberOfMaxSequal = listOfNumbers[i];
                }
            }

            for (int i = 0; i <= maxCounter; i++)
            {
                listOfEqualDigits.Add(numberOfMaxSequal);
            }
            Console.WriteLine(string.Join(" ", listOfEqualDigits));
        }
    }
}
