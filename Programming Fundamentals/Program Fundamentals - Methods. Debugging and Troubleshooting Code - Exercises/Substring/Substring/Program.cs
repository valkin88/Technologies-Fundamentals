using System;
using System.Collections.Generic;
using System.Linq;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            const char letterP = 'p';
            bool hasMatch = false;
            for (int i = 0; i < textInput.Length; i++)
            {
                if (textInput[i] == letterP)
                {
                    hasMatch = true;
                    int endIndex = count + 1 > textInput.Length - i ? textInput.Length - i : count + 1;
                    string matchedString = textInput.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += count;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
