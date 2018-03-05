using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionatyOfData = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                string emailOfPerson = Console.ReadLine();

                if (emailOfPerson.Contains(".us") || emailOfPerson.Contains(".uk"))
                {
                    continue;
                }
                else
                {
                    dictionatyOfData.Add(input, emailOfPerson);
                }

            }
            foreach (var item in dictionatyOfData)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
