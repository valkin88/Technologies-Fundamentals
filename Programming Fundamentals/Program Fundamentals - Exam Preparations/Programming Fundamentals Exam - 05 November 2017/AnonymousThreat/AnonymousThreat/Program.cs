using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExamProblemFour
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] valuesInput = Console.ReadLine().Split(new string[] { "{", "}", @"\s*?", "\t", @"\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> groupOne = new List<string>();
            List<string> groupTwo = new List<string>();
            List<string> groupThree = new List<string>();
            string pattern = @"([a-zA-Z]+)(.+)(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection collection = regex.Matches(inputLine);
            foreach (Match match in collection)
            {
                groupOne.Add(Convert.ToString(match.Groups[1]).Trim());
                groupTwo.Add(Convert.ToString(match.Groups[2]).Trim());
                groupThree.Add(Convert.ToString(match.Groups[3]).Trim());
            }

            StringBuilder builder = new StringBuilder(inputLine);
            if (valuesInput.Length <= groupTwo.Count)
            {
                for (int i = 0; i < valuesInput.Length; i++)
                {
                    builder.Replace(groupTwo[i], valuesInput[i]);
                }
            }
            else
            {
                for (int i = 0; i < groupTwo.Count; i++)
                {
                    builder.Replace(groupTwo[i], valuesInput[i]);
                }
            }
            Console.WriteLine(builder);
        }
    }
}
