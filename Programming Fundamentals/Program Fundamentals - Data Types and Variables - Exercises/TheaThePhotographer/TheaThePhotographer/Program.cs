using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPicturesTaken = long.Parse(Console.ReadLine());
            long filterTimeForOnePicture = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTimeForOnePicture = long.Parse(Console.ReadLine());

            double filteredPictures = totalPicturesTaken * (filterFactor / 100.0);
            long timeForTotalPictures = totalPicturesTaken * filterTimeForOnePicture;
            long timeForUploadAllPictures = (long)(Math.Ceiling(filteredPictures)) * uploadTimeForOnePicture;
            long totalTimeForAllPictures = timeForTotalPictures + timeForUploadAllPictures;

            long daysForPicturesToBeReady = totalTimeForAllPictures / 86400;
            long hoursForPicturesToBeReady = (totalTimeForAllPictures - (daysForPicturesToBeReady * 86400)) / 3600;
            long minutesForPicturesToBeReady = (totalTimeForAllPictures - (daysForPicturesToBeReady * 86400) - (hoursForPicturesToBeReady * 3600)) / 60;
            long secondsForPicturesToBeReady = totalTimeForAllPictures - (daysForPicturesToBeReady * 86400) - (hoursForPicturesToBeReady * 3600) - (minutesForPicturesToBeReady * 60);

            
            
            Console.WriteLine($"{daysForPicturesToBeReady:0}:{hoursForPicturesToBeReady:00}:{minutesForPicturesToBeReady:00}:{secondsForPicturesToBeReady:00}");
        }
    }
}
