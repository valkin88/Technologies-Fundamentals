using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;



class ExamProblemOne
{
    static void Main()
    {
        BigInteger countOfAffectedWebSites = BigInteger.Parse(Console.ReadLine());
        BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
        List<string> websites = new List<string>();
        decimal siteLoss = 0;
        decimal totalMoneyLoss = 0;
        BigInteger securityToken = 1;
        for (int i = 0; i < countOfAffectedWebSites; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (input[0].Contains(' ') || input.Length < 3 || input.Length > 3)
            {
                continue;
            }
            websites.Add(input[0]);
            decimal siteVisits = decimal.Parse(input[1]);
            decimal siteCommercialPricePerVisit = decimal.Parse(input[2]);
            siteLoss = siteVisits * siteCommercialPricePerVisit;
            totalMoneyLoss += siteLoss;
            securityToken *= securityKey;

        }
        foreach (var website in websites)
        {
            Console.WriteLine(website);
        }
        Console.WriteLine($"Total Loss: {totalMoneyLoss:f20}");
        Console.WriteLine($"Security Token: {securityToken}");
    }
}

