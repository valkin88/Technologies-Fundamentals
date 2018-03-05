using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[()\/ ]*(\b[a-zA-Z][a-zA-Z0-9_]{2,}\b)[()\/ ]*";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection userNames = regex.Matches(input);

            List<string> listOfUserNames = new List<string>();
            foreach (Match names in userNames)
            {
                if (Convert.ToString(names.Groups[1]).Length <= 25)
                {
                    listOfUserNames.Add(Convert.ToString(names.Groups[1]));
                }

            }

            int sumOfUserNames = 0;
            int maxSum = int.MinValue;
            int firstIndexOfUserName = -1;
            int nextIndexOfUserName = -1;
            for (int i = 1; i < listOfUserNames.Count; i++)
            {
                sumOfUserNames = listOfUserNames[i - 1].Length + listOfUserNames[i].Length;
                if (sumOfUserNames > maxSum)
                {
                    maxSum = sumOfUserNames;
                    firstIndexOfUserName = i - 1;
                    nextIndexOfUserName = i;
                }
            }
            Console.WriteLine(listOfUserNames[firstIndexOfUserName]);
            Console.WriteLine(listOfUserNames[nextIndexOfUserName]);


        }
    }
}
