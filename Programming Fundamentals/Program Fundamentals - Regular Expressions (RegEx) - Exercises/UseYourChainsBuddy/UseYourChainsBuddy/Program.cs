using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class Program
    {

        public static string fromAtoM = "abcdefghijklm";
        public static string fromNtoZ = "nopqrstuvwxyz";
        public static char[] arrayOfNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string patternFromPToP = @"(<p>)(.*?)(<\/p>)";
            List<string> listOfText = new List<string>();
            Regex regexFromPToP = new Regex(patternFromPToP);
            MatchCollection matches = regexFromPToP.Matches(input);

            foreach (Match match in matches)
            {
                var replaced = Regex.Replace(match.Groups[2].ToString(), "[^a-z0-9]", " ");
                listOfText.Add(replaced);
            }

            string itemOfList = String.Empty;
            string convertedString = String.Empty;

            for (int i = 0; i < listOfText.Count; i++)
            {
                itemOfList = listOfText[i];

                convertedString = ConvertionOfString(fromAtoM, fromNtoZ, arrayOfNumbers, itemOfList, convertedString);

            }
            PrintResult(convertedString);
        }

        private static void PrintResult(string convertedString)
        {
            string[] result = convertedString.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write(String.Join(" ", result));
            Console.WriteLine();
        }

        private static string ConvertionOfString(string fromAtoM, string fromNtoZ, char[] arrayOfNumbers, string itemOfList, string convertedString)
        {
            for (int d = 0; d < itemOfList.Length; d++)
            {

                if (fromAtoM.Contains(itemOfList[d]))
                {
                    int index = fromAtoM.IndexOf(itemOfList[d]);
                    convertedString += fromNtoZ.ElementAt(index);
                }
                else if (fromNtoZ.Contains(itemOfList[d]))
                {
                    int index = fromNtoZ.IndexOf(itemOfList[d]);
                    convertedString += fromAtoM.ElementAt(index);
                }
                else
                {
                    convertedString += itemOfList[d];
                }
            }

            return convertedString;
        }
    }
}
