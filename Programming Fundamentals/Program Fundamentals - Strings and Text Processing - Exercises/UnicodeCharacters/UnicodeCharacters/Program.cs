using System;
using System.Globalization;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var chr in input)
            {
                Console.Write("\\u{0:x4}", (int)chr);
            }
            Console.WriteLine();
        }
    }
}
