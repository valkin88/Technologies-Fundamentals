using System;
using System.Collections.Generic;
using System.Linq;

namespace PhonebookUpgrade
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

                switch (comand)
                {
                    case "A":
                        string nameOfInput = listOfAddedNameAndNumber[1];
                        string numberOfInput = listOfAddedNameAndNumber[2];
                        phoneBook[nameOfInput] = numberOfInput;
                        break;
                    case "S":
                        string nameToSearch = listOfAddedNameAndNumber[1];
                        if (phoneBook.ContainsKey(nameToSearch))
                        {
                            Console.WriteLine($"{nameToSearch} -> {phoneBook[nameToSearch]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {nameToSearch} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var name in phoneBook)
                        {
                            Console.WriteLine($"{name.Key} -> {name.Value}");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
