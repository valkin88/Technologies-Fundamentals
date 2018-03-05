using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputOfRange = Console.ReadLine();
            string text = Console.ReadLine();

            int[] range = inputOfRange.Split().Select(int.Parse).ToArray();
            int startIndex = range[0];
            int rangeOfWord = range[1];

            string pattern = $@"(?<=\|<)(?:[^|]{{{startIndex}}})([^|]{{0,{rangeOfWord}}}).*?(?=$|\|<)";
            Regex regex = new Regex(pattern);
            string result = String.Empty;
            foreach (Match match in regex.Matches(text))
            {
                  result += match.Groups[1] + ", ";
            }
            Console.WriteLine(result.TrimEnd(',', ' '));
        }
    }
}
