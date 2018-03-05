using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var populationCityCoutry = new Dictionary<string, Dictionary<string, int>>();
            var countryPolulation = new Dictionary<string, long>();

            while (input != "report")
            {
                string[] tokens = input.Split('|').ToArray();
                var city = tokens[0];
                var country = tokens[1];
                var popuation = int.Parse(tokens[2]);

                if (!populationCityCoutry.ContainsKey(country))
                {
                    populationCityCoutry[country] = new Dictionary<string, int>();
                    countryPolulation.Add(country, 0);
                }
                countryPolulation[country] += popuation;
                populationCityCoutry[country][city] = popuation;

                input = Console.ReadLine();
            }

            foreach (var item in countryPolulation.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                foreach (var elem in populationCityCoutry[item.Key].OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"=>{elem.Key}: {elem.Value}");
                }

            }
        }
    }
}
