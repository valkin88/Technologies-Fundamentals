using System;
using System.Collections.Generic;
using System.Linq;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayOfLetters = Console
                                     .ReadLine()
                                     .ToLower()
                                     .ToCharArray();

            foreach (var letter in arrayOfLetters)
            {

                Console.WriteLine($"{letter} -> {Math.Abs(97 - letter)}");
            }

        }
    }
}
