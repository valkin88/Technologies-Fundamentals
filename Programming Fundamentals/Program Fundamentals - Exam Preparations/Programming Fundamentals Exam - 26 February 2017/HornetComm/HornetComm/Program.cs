using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string messageRegex = @"^([\d]+) <-> ([0-9a-zA-Z]+)$";
            string broadcastRegex = @"^([\D]+) <-> ([0-9a-zA-Z]+)$";

            Regex message = new Regex(messageRegex);
            Regex broadcast = new Regex(broadcastRegex);

            string input;

            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                var inputArgs = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                if (message.IsMatch(input))
                {
                    messages.Add($"{String.Join("", inputArgs[0].ToCharArray().Reverse())} -> {inputArgs[1]}");

                }

                if (broadcast.IsMatch(input))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach  (char c in inputArgs[1].ToCharArray())
                    {
                        if (Char.IsLower(c))
                        {
                            sb.Append(Char.ToUpper(c));
                            continue;
                        }
                        if (Char.IsUpper(c))
                        {
                            sb.Append(Char.ToLower(c));
                            continue;
                        }

                        sb.Append(c);
                    }
                    broadcasts.Add($"{sb.ToString()} -> {inputArgs[0]}");
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var item in messages)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

    }
}
