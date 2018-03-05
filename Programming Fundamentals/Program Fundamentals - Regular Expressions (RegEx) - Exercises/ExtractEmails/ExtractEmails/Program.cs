using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"^|(?<=\s)([a-zA-Z]+[._-]?\w+)@((\w+[-|.]?\w+))((\.\w+)+)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match emailMatch in matches)
            {
               Console.WriteLine(emailMatch);
            }
        }
    }
}
