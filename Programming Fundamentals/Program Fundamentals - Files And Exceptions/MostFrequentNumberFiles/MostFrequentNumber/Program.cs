using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("Input.txt");
            List<int> listOfNumbers = input.Split(' ').Select(int.Parse).ToList();
            File.Delete("output.txt");
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
            File.WriteAllText("output.txt", Convert.ToString(mostFrequentNumber));
        }
    }
}
