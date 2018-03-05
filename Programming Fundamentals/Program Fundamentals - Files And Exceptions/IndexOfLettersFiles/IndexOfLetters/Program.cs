using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("Input.txt");
            File.Delete("output.txt");
            char[] arrayOfLetters = input
                                     .ToLower()
                                     .ToCharArray();

            string[] output = arrayOfLetters.Select(x => $"{x} -> {Math.Abs(97 - x)}").ToArray();

            File.WriteAllLines("output.txt", output);

        }
    }
}
