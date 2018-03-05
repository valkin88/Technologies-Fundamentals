using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionatyOfData = new Dictionary<string, string>();
            string[] input = File.ReadAllLines("Input.txt");
            File.Delete("output.txt");
            for (int i = 0; i < input.Length; i += 2)
            {
                if (input[i] == "stop" || input[i + 1] == "stop")
                {
                    break;
                }
                string name = input[i];
                string emailOfPerson = input[i + 1];

                if (emailOfPerson.Contains(".us") || emailOfPerson.Contains(".uk"))
                {
                    continue;
                }
                else
                {
                    dictionatyOfData.Add(name, emailOfPerson);
                }
            }
            var output = dictionatyOfData.Select(x => $"{x.Key} -> {x.Value}").ToList();
            File.WriteAllLines("output.txt", output);
        }
    }
}
