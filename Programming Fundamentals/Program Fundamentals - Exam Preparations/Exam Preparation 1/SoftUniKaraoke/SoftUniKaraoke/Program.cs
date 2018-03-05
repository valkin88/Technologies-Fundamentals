using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SoftUniKaraoke
{
    static void Main()
    {
        var karaokeInfo = new Dictionary<string, List<string>>();

        string[] participantList = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        List<string> songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        
        while (true)
        {
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "dawn")
            {
                break;
            }
            if (!karaokeInfo.ContainsKey(input[0]) && participantList.Contains(input[0]))
            {
                karaokeInfo.Add(input[0], new List<string>());
            }
            if (karaokeInfo.ContainsKey(input[0]) &&
                !karaokeInfo[input[0]].Contains(input[2]) && 
                songs.Contains(input[1]))
            {
                karaokeInfo[input[0]].Add(input[2]);
            }
        }

        if (karaokeInfo.Values.Count() != 0 && karaokeInfo.Keys.Count() != 0)
        {
            foreach (var singer in karaokeInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (singer.Value.Count > 0)
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                    var sortedAwards =
                from award in singer.Value
                orderby award ascending
                select award;
                    foreach (var award in sortedAwards)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No awards");
        }
    }
}

