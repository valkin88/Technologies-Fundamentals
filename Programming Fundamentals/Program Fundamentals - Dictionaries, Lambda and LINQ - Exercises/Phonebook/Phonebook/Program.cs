using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] listOfAddedNameAndNumber = input.Split(' ').ToArray();
                string comand = listOfAddedNameAndNumber[0];
                string nameOfInput = listOfAddedNameAndNumber[1];

                switch (comand)
                {
                    case "A":
                        string numberOfInput = listOfAddedNameAndNumber[2];
                        phoneBook[nameOfInput] = numberOfInput;
                        break;
                    case "S":
                        
                        if (phoneBook.ContainsKey(nameOfInput))
                        {
                            Console.WriteLine($"{nameOfInput} -> {phoneBook[nameOfInput]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {nameOfInput} does not exist.");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
