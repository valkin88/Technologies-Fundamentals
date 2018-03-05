using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> listOfMaterials = new SortedDictionary<string, int>();
            SortedDictionary<string, int> listOfJunkMaterials = new SortedDictionary<string, int>();
            listOfMaterials.Add("motes", 0);
            listOfMaterials.Add("fragments", 0);
            listOfMaterials.Add("shards", 0);
            bool isItOver = true;
            while (isItOver)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();

                for (int i = 0; i < input.Length; i +=2)
                {
                    if (input[i + 1] == "shards" || input[i + 1] == "fragments" || input[i + 1] == "motes")
                    {
                        if (listOfMaterials.ContainsKey(input[i+1]))
                        {
                            listOfMaterials[input[i + 1]] += int.Parse(input[i]);

                        }
                        if (listOfMaterials[input[i + 1]] >= 250)
                        {
                            isItOver = false;
                            if (listOfMaterials.Where(x => x.Value >= 250).Any(x => x.Key == "shards"))
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                listOfMaterials[input[i + 1]] -= 250;
                            }
                            else if (listOfMaterials.Where(x => x.Value >= 250).Any(x => x.Key == "fragments"))
                            {
                                Console.WriteLine("Valanyr obtained!");
                                listOfMaterials[input[i + 1]] -= 250;
                            }
                            else if (listOfMaterials.Where(x => x.Value >= 250).Any(x => x.Key == "motes"))
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                listOfMaterials[input[i + 1]] -= 250;
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (!listOfJunkMaterials.ContainsKey(input[i + 1]))
                        {
                            listOfJunkMaterials.Add(input[i+ 1], int.Parse(input[i]));

                        }
                        else
                        {
                            listOfJunkMaterials[input[i + 1]] += int.Parse(input[i]);
                        }
                    }
                }
                
            }

            foreach (var item in listOfMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }
            foreach (var item in listOfJunkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
