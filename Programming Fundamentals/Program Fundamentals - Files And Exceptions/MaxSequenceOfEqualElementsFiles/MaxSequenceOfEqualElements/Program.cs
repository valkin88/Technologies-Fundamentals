using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MaxSequencOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("Input.txt");
            List<int> listOfNumbers = input.Split(' ').Select(int.Parse).ToList();
            List<int> listOfEqualDigits = new List<int>();
            File.Delete("output.txt");
            int maxCounter = 0;
            int numberOfMaxSequal = listOfNumbers[0];

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
            var output = String.Join(" ", listOfEqualDigits);
            File.WriteAllText("output.txt", output);
        }
    }
}

