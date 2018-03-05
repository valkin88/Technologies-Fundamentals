using System;
using System.Globalization;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long numberOfSteps = long.Parse(Console.ReadLine()) % 86400;
            long timeForEachStep = long.Parse(Console.ReadLine()) % 86400;
            long sumOfTime = numberOfSteps * timeForEachStep;
            DateTime timeOfArrivel = timeOfLeaving.AddSeconds(sumOfTime);

            Console.WriteLine($"Time Arrival: {timeOfArrivel:HH:mm:ss}");
        }
    }
}
