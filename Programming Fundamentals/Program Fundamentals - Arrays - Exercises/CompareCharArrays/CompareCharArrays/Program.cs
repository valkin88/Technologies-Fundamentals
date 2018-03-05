using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInputOfStrings = Console.ReadLine().Split(' ').ToArray();
            string[] secondInputOfStrings = Console.ReadLine().Split(' ').ToArray();

            string concatenationOfFirstArray = "";
            string concatenationOfSecondArray = "";

            List<string> listOfConcatenatedStrings = new List<string>();
            for (int i = 0; i < firstInputOfStrings.Length; i++)
            {
                concatenationOfFirstArray += firstInputOfStrings[i] + "";
            }
            listOfConcatenatedStrings.Add(concatenationOfFirstArray);

            for (int i = 0; i < secondInputOfStrings.Length; i++)
            {
                concatenationOfSecondArray += secondInputOfStrings[i] + "";
            }
            listOfConcatenatedStrings.Add(concatenationOfSecondArray);

            listOfConcatenatedStrings.Sort();

            Console.WriteLine(string.Join("\r\n", listOfConcatenatedStrings));
        }
    }
}
