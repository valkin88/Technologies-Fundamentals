using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


 class NetherRealms
 {
     static void Main()
     {
        string[] deamonNames = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        string healthPattern = @"([^\-\+\.\/\*0-9\s*])";
        string dmgPattern = @"(\-?\+?[0-9\.0-9]+|\-?\+?[0=9])";
        string multAndDivPattern = @"(\*+?|\/+?)";

        Regex regexHealth = new Regex(healthPattern);
        Regex regexDMG = new Regex(dmgPattern);
        Regex regexMultAndDiv = new Regex(multAndDivPattern);

        SortedDictionary<string, Dictionary<int, double>> sortedInfo = 
                                                          new SortedDictionary<string, Dictionary<int, double>>();

        for (int i = 0; i < deamonNames.Length; i++)
        {
            string deamon = deamonNames[i].Trim();
            if (deamon.Contains(' ') || deamon.Contains(','))
            {
                continue;
            }
            else
            {
                int health = 0;
                double dmg = 0;
                MatchCollection charachtersForHealth = regexHealth.Matches(deamon);
                foreach (Match ch in charachtersForHealth)
                {
                    health += char.Parse(Convert.ToString(ch));
                }
                MatchCollection charachtersForDMG = regexDMG.Matches(deamon);
                foreach (Match ch in charachtersForDMG)
                {
                    dmg += double.Parse(Convert.ToString(ch));
                }
                MatchCollection multAndDivChars = regexMultAndDiv.Matches(deamon);
                foreach (Match ch in multAndDivChars)
                {
                    if (Convert.ToString(ch) == "*")
                    {
                        dmg *= 2;
                    }
                    else
                    {
                        dmg /= 2;
                    }
                }
                if (!sortedInfo.ContainsKey(deamon))
                {
                    sortedInfo.Add(deamon, new Dictionary<int, double>());
                    sortedInfo[deamon].Add(health, dmg);
                }
            }
            
        }
        foreach (var deamon in sortedInfo)
        {
            Console.Write($"{deamon.Key} - ");
            var healthAndDmg = deamon.Value;
            foreach (var info in healthAndDmg)
            {
                Console.Write($"{info.Key} health, {info.Value:f2} damage");
            }
            Console.WriteLine();
        }

     }
 }

