using System;
using System.Collections.Generic;
using System.Linq;

namespace CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dataOfFirstCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] dataOfSecondCirle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int x1FirstCircle = dataOfFirstCircle[0];
            int y1FirstCircle = dataOfFirstCircle[1];
            int radiusOfFirstCircle = dataOfFirstCircle[2];
            int x2SecondCircle = dataOfSecondCirle[0];
            int y2SecondCircle = dataOfSecondCirle[1];
            int radiusOfSecondCircle = dataOfSecondCirle[2];

            double distanceBetweenTwoCentres = Math.Sqrt((x2SecondCircle - x1FirstCircle) * (x2SecondCircle - x1FirstCircle)
                                                         + (y2SecondCircle - y1FirstCircle) * (y2SecondCircle - y1FirstCircle));

            if (distanceBetweenTwoCentres <= radiusOfFirstCircle + radiusOfSecondCircle)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
