using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dictionaryOfSavedInformation = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] listOfInformation = input.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string ipAdress = listOfInformation[1];
                string userName = listOfInformation.Last();

                if (!dictionaryOfSavedInformation.ContainsKey(userName))
                {
                    dictionaryOfSavedInformation[userName] = new Dictionary<string, int>();
                    dictionaryOfSavedInformation[userName].Add(ipAdress, 1);
                }
                else
                {
                    if (dictionaryOfSavedInformation[userName].ContainsKey(ipAdress))
                    {
                        dictionaryOfSavedInformation[userName][ipAdress]++;
                    }
                    else
                    {
                        dictionaryOfSavedInformation[userName].Add(ipAdress, 1);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var userName in dictionaryOfSavedInformation.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{userName}: ");
                string ipString = String.Empty;
                var orderedDictionaryofIps = dictionaryOfSavedInformation[userName];
                foreach (var ip in orderedDictionaryofIps)
                {
                    ipString += $"{ip.Key} => {ip.Value}, ";
                }
                ipString = ipString.Substring(0, ipString.Length - 2);
                ipString += ".";
                Console.WriteLine(ipString);
            }
        }
    }
}
