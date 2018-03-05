using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfResources = new Dictionary<string, long>();
            var input = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            for (int i = 0; i < input.Length; i += 2)
            {

                if (input[i] == "stop" || input[i+1] == "stop")
                {
                    break;
                }
                var resource = input[i];
                var count = long.Parse(input[i + 1]);

                if (!listOfResources.ContainsKey(resource))
                {
                    listOfResources[resource] = count;
                }
                else
                {
                    listOfResources[resource] += count;
                }

            }

                var finalOutput = listOfResources.Select(resorce => $"{resorce.Key} -> {resorce.Value}").ToList();
                File.WriteAllLines("output.txt", finalOutput);


        }
    }
}
