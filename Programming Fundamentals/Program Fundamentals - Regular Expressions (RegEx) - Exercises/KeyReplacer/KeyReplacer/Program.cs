using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keysInput = Console.ReadLine().Split(new char[] { '\\', '<', '|' }, StringSplitOptions.RemoveEmptyEntries);
            string startKey = keysInput[0];
            string endKey = keysInput[2];

            string textInput = Console.ReadLine();
            string extractionPattern = $@"{startKey}(\w*?){endKey}";

            Regex regexExtraction = new Regex(extractionPattern);
            MatchCollection extractedCollection = regexExtraction.Matches(textInput);

            string result = String.Empty;
            foreach (Match word in extractedCollection)
            {
                result += Convert.ToString(word.Groups[1]);
            }
            if (result == String.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
