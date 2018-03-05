using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float hoursInSeconds = (hours * 60) * 60;
            float minutesInSeconds = minutes * 60;
            float secondsInHours = (seconds / 60) / 60;
            float minutesInHours = minutes / 60;
            float metersInKm = distanceInMeters / 1000;
            float metersToMiles = distanceInMeters / 1609;
            float metersPerSecond = distanceInMeters / (seconds + hoursInSeconds + minutesInSeconds);
            float kmPerHour = metersInKm / (hours + secondsInHours + minutesInHours);
            float milesPerHour = metersToMiles / (hours + secondsInHours + minutesInHours);



            Console.WriteLine("{0}", metersPerSecond);
            Console.WriteLine("{0}", kmPerHour);
            Console.WriteLine("{0}", milesPerHour);
        }
    }
}
