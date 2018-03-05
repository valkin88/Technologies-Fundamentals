using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CharityMarathon
{
    static void Main()
    {
        long lenghtDays = long.Parse(Console.ReadLine());
        long numberOfRunners = long.Parse(Console.ReadLine());
        long averageLaps = long.Parse(Console.ReadLine());
        long trackLenght = long.Parse(Console.ReadLine());
        long trackCapacity = long.Parse(Console.ReadLine());
        decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

        long maxRunners = trackCapacity * lenghtDays;
        decimal totalKilometers = 0;
        long totalMeters = 0;
        decimal totalMoneyRaised = 0;
        if (numberOfRunners <= maxRunners)
        {
            totalMeters = numberOfRunners * averageLaps * trackLenght;
            totalKilometers = totalMeters / 1000;
            totalMoneyRaised = totalKilometers * moneyPerKilometer;
        }
        else
        {
            numberOfRunners = maxRunners;
            totalMeters = numberOfRunners * averageLaps * trackLenght;
            totalKilometers = totalMeters / 1000;
            totalMoneyRaised = totalKilometers * moneyPerKilometer;
        }
        Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
    }
}

