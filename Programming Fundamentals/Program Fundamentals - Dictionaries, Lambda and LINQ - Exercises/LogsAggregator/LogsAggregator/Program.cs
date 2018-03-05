using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> listofInformation = new SortedDictionary<string, SortedDictionary<string, int>>();

            int countOfLogsLins = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLogsLins; i++)
            {
                string[] arrayOfInputInformation = Console.ReadLine().Split(' ').ToArray();
                string userName = arrayOfInputInformation[1];
                string ipAdress = arrayOfInputInformation[0];
                int durationOfUser = int.Parse(arrayOfInputInformation[2]);

                if (!listofInformation.ContainsKey(userName))
                {
                    listofInformation[userName] = new SortedDictionary<string, int>();
                    listofInformation[userName][ipAdress] = durationOfUser;
                }
                else if (!listofInformation[userName].ContainsKey(ipAdress))
                {
                    listofInformation[userName].Add(ipAdress, durationOfUser);
                }
                else
                {
                    listofInformation[userName][ipAdress] += durationOfUser;
                }
            }
            foreach (var user in listofInformation)
            {
                string ipFinalList = String.Empty;
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");
                foreach (var ip in user.Value.Distinct())
                {
                    ipFinalList += $"{ip.Key}, ";
                }
                ipFinalList = ipFinalList.Substring(0, ipFinalList.Length - 2);
                ipFinalList += "]";
                Console.WriteLine(ipFinalList);
            }
        }
    }
}
