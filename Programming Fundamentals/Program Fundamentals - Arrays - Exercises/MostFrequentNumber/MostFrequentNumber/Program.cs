using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxCounter = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < listOfNumbers.Count; j++)
                {
                    if (listOfNumbers[i] == listOfNumbers[j])
                    {
                        counter++;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        mostFrequentNumber = listOfNumbers[i];
                    }
                }
            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}
