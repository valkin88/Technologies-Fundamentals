using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace CountWorkingDays
{
    class Program
    {
        private static int yyyy;

        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            Days dates = new Days();
            dates.startDate = DateTime.ParseExact(dateOne, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            dates.endDate = DateTime.ParseExact(dateTwo, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] hollidaysOfTheYear = new DateTime[12];
            hollidaysOfTheYear[0] = new DateTime(4, 01, 01);
            hollidaysOfTheYear[1] = new DateTime(4, 03, 03);
            hollidaysOfTheYear[2] = new DateTime(4, 05, 01);
            hollidaysOfTheYear[3] = new DateTime(4, 05, 06);
            hollidaysOfTheYear[4] = new DateTime(4, 05, 24);
            hollidaysOfTheYear[5] = new DateTime(4, 09, 06);
            hollidaysOfTheYear[6] = new DateTime(4, 09, 22);
            hollidaysOfTheYear[7] = new DateTime(4, 11, 01);
            hollidaysOfTheYear[9] = new DateTime(4, 12, 24);
            hollidaysOfTheYear[10] = new DateTime(4, 12, 25);
            hollidaysOfTheYear[11] = new DateTime(4, 12, 26);

            int counterOfWorkingDays = 0;

            for (DateTime i = dates.startDate; i <= dates.endDate; i = i.AddDays(1))
            {
               DayOfWeek day = i.DayOfWeek;

               DateTime tempYear = new DateTime(4, i.Month, i.Day); if (!hollidaysOfTheYear.Contains(tempYear) && (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday)))
               {
                   counterOfWorkingDays++;
               }
            }
            Console.WriteLine(counterOfWorkingDays);


        }
    }

    public class Days
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

      
    }
}
