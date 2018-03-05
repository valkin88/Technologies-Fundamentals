using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RageQuit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string patternNonDigit = @"\D+";
            string patternDigit = @"\d+";

            List<string> nonDigits = new List<string>(AddElementsInList(input, patternNonDigit));
            List<string> digits = new List<string>(AddElementsInList(input, patternDigit));

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < nonDigits.Count; i++)
            {
                int numberToMultiply = int.Parse(digits[i]);
                int counter = 1;
                while (counter <= numberToMultiply)
                {
                    result.Append(nonDigits[i]);
                    counter++;
                }
            }
            Console.WriteLine("Unique symbols used: {0}", result.ToString().ToUpper().Distinct().Count());
            Console.WriteLine(result.ToString().ToUpper());

        }

        public static List<string> AddElementsInList(string input, string pattern)
        {
            Regex regexNonDigits = new Regex(pattern);
            List<string> elements = new List<string>();
            MatchCollection collectionOfNonDigits = regexNonDigits.Matches(input);

            foreach (Match item in collectionOfNonDigits)
            {
                elements.Add(Convert.ToString(item));
            }

            return elements;
        }
    }
}
