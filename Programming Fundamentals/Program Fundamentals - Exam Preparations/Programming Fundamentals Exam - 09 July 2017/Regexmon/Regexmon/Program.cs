using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
            string pattern = @"([^a-zA-Z-]+)|([a-zA-Z]+-[a-zA-Z]+)";
            Regex regex = new Regex(pattern);
            MatchCollection collection = regex.Matches(textInput);
            List<string> listOfMatches = new List<string>();
            List<string> listResult = new List<string>();
            foreach (Match match in collection)
            {
                if (Convert.ToString(match.Groups[1]) != String.Empty)
                {
                    listOfMatches.Add(Convert.ToString(match.Groups[1]));
                }
                if (Convert.ToString(match.Groups[2]) != String.Empty)
                {
                    listOfMatches.Add(Convert.ToString(match.Groups[2]));
                }

            }

            int counter = 1;
            int index = 0;
            while (index < listOfMatches.Count)
            {
                if (counter % 2 != 0)
                {
                    if (!listOfMatches[index].Contains("-"))
                    {
                        listResult.Add(listOfMatches[index]);
                        counter++;
                    }
                    index++;
                }
                else if (counter % 2 == 0)
                {
                    if (listOfMatches[index].Contains("-"))
                    {
                        listResult.Add(listOfMatches[index]);
                        counter++;
                    }
                    index++;
                }
            }
            foreach (var matches in listResult)
            {
                Console.WriteLine(matches);
            }

        }
    }
}
