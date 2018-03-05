using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());

            double sumStudio = 0.0;
            double sumDouble = 0.0;
            double sumSuite = 0.0;

            if (month == "may" || month == "october")
            {
                if (nightsCount > 7 && month == "october")
                {
                    
                    sumStudio = ((nightsCount - 1) * 50.00) * 0.95;
                    sumDouble = nightsCount * 65.00;
                    sumSuite = nightsCount * 75.00;
                }
                else if (nightsCount > 7 && month == "may")
                {
                    sumStudio = (nightsCount * 50.00) * 0.95;
                    sumDouble = nightsCount * 65.00;
                    sumSuite = nightsCount * 75.00;
                }
                else
                {
                    sumStudio = nightsCount * 50.00;
                    sumDouble = nightsCount * 65.00;
                    sumSuite = nightsCount * 75.00;
                }
            }
            else if (month == "june" || month == "september")
            {
                if (nightsCount > 7 && month == "september")
                {
                    sumStudio = (nightsCount - 1) * 60.00;
                    sumDouble = nightsCount * 72.00;
                    sumSuite = nightsCount * 82.00;
                }
                else if (nightsCount > 14 && month == "september")
                {
                    sumStudio = nightsCount * 60.00;
                    sumDouble = (nightsCount * 72.00) * 0.9;
                    sumSuite = nightsCount * 82.00;
                }
                else if (nightsCount > 14 && month == "june")
                {
                    sumStudio = nightsCount * 60.00;
                    sumDouble = (nightsCount * 72.00) * 0.9;
                    sumSuite = nightsCount * 82.00;
                }
                else
                {
                    sumStudio = nightsCount * 60.00;
                    sumDouble = nightsCount * 72.00;
                    sumSuite = nightsCount * 82.00;
                }
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                if (nightsCount > 14)
                {
                    sumStudio = nightsCount * 68.00;
                    sumDouble = nightsCount * 77.00;
                    sumSuite = (nightsCount * 89.00) * 0.85;
                }
                else
                {
                    sumStudio = nightsCount * 68.00;
                    sumDouble = nightsCount * 77.00;
                    sumSuite = nightsCount * 89.00;
                }
            }
            Console.WriteLine($"Studio: {sumStudio:f2} lv.");
            Console.WriteLine($"Double: {sumDouble:f2} lv.");
            Console.WriteLine($"Suite: {sumSuite:f2} lv.");
        }
    }
}
