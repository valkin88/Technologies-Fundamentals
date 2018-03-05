using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfResources = new Dictionary<string, long>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                long countOfResources = long.Parse(Console.ReadLine());

                if (!listOfResources.ContainsKey(resource))
                {
                    listOfResources.Add(resource, countOfResources);
                }
                else
                {
                    listOfResources[resource] += countOfResources;
                }

            }
            foreach(var item in listOfResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
