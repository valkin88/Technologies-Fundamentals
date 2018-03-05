using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnduranceRally
{
    class Program
    {
        static void Main()
        {
            string[] listOfNames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string trackInput = Console.ReadLine();
            double[] trackLayout = trackInput
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(double.Parse)
                                .ToArray();

            string checkPointInput = Console.ReadLine();
            List<int> checkPoints = checkPointInput
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToList();

            for (int drivers = 0; drivers < listOfNames.Length; drivers++)
            {
                double fuelLeft = listOfNames[drivers][0];
                int indexReached = 0;

                for (int i = 0; i < trackLayout.Length; i++)
                {
                    bool isEqual = false;
                    isEqual = FindEqualIndexes(checkPoints, isEqual, i);

                    SubtractingFuel(trackLayout, ref fuelLeft, ref indexReached, isEqual, i);

                    if (fuelLeft <= 0)
                    {
                        Console.WriteLine($"{listOfNames[drivers]} - reached {indexReached}");
                        break;
                    }
                    else
                    {
                        indexReached++;
                    }
                }
                if (fuelLeft > 0)
                {
                    Console.WriteLine($"{listOfNames[drivers]} - fuel left {fuelLeft:f2}");
                }
           
            }
        }

        private static void SubtractingFuel(double[] trackLayout, ref double fuelLeft, ref int indexReached, bool isEqual, int i)
        {
            if (isEqual)
            {
                fuelLeft += trackLayout[i];
            }
            else
            {
                fuelLeft -= trackLayout[i];
            }
        }

        private static bool FindEqualIndexes(List<int> checkPoints, bool isEqual, int i)
        {
            for (int j = 0; j < checkPoints.Count; j++)
            {
                if (i == checkPoints[j])
                {
                    isEqual = true;
                    break;
                }
            }

            return isEqual;
        }
    }
}
