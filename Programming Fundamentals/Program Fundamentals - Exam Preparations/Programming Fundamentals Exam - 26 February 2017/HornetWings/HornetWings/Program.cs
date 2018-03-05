using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double distanceTravel = wingFlaps / 1000 * distance;
            Console.WriteLine($"{distanceTravel:f2} m.");

            double timeOfBreaks = wingFlaps / endurance * 5;
            double timeTravel = wingFlaps / 100;
            Console.WriteLine($"{timeOfBreaks + timeTravel} s.");
        }
    }
}
