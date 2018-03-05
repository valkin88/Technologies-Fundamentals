using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ExamProblemThree
{
    static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, Dictionary<string, long>> storingSets = new Dictionary<string, Dictionary<string, long>>();
        List<string> sets = new List<string>();
        List<string> sets2 = new List<string>();
        string dataKey = String.Empty;
        string dataSet = String.Empty;
        long dataSize = 0;
        while (true)
        {
            if (input == "thetinggoesskrra")
            {
                break;
            }
            string[] lineinput = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (!lineinput[0].Contains(' ') || !lineinput[0].Contains('|') || !lineinput[0].Contains('>') || !lineinput[0].Contains('-') ||
                !lineinput[2].Contains(' ') || !lineinput[2].Contains('|') || !lineinput[2].Contains('>') || !lineinput[2].Contains('-'))
            {
                if (lineinput.Length == 1)
                {
                    dataSet = lineinput[0];
                    sets.Add(dataSet);
                }
                else
                {
                    dataSet = lineinput[2];
                    dataKey = lineinput[0];
                    dataSize = long.Parse(lineinput[1]);
                    if (!storingSets.ContainsKey(dataSet))
                    {
                        storingSets.Add(dataSet, new Dictionary<string, long>());
                        storingSets[dataSet].Add(dataKey, 0);
                        storingSets[dataSet][dataKey] += dataSize;
                        sets2.Add(dataSet);
                    }
                    else
                    {
                        storingSets[dataSet].Add(dataKey, 0);
                        storingSets[dataSet][dataKey] += dataSize;
                        sets2.Add(dataSet);

                    }
                }
                input = Console.ReadLine();
            }
        }
        if (sets2.Count > 1)
        {
            var sortedDict = storingSets.OrderByDescending(x => x.Value.Values.Sum());
            int counter = 0;
            foreach (var item in sortedDict)
            {
                if (sets.Contains(item.Key))
                {
                    counter++;
                    Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");
                    foreach (var keys in item.Value)
                    {
                        Console.WriteLine($"$.{keys.Key}");
                    }
                    if (counter > 0)
                    {
                        break;
                    }

                }
            }
        }
       
    }
}

