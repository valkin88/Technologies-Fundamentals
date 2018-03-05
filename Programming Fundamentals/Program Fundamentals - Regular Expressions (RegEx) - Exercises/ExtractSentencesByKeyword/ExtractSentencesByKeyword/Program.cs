using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split(new char[] { '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"\b" + word + @"\b";
            Regex regex = new Regex(pattern);
            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }

        }
    }
}
