using System;

namespace LongerLine
{
    class Program
    {

        static double coordinateX1 = double.Parse(Console.ReadLine());
        static double coordinateY1 = double.Parse(Console.ReadLine());
        static double coordinateX2 = double.Parse(Console.ReadLine());
        static double coordinateY2 = double.Parse(Console.ReadLine());
        static double coordinateX3 = double.Parse(Console.ReadLine());
        static double coordinateY3 = double.Parse(Console.ReadLine());
        static double coordinateX4 = double.Parse(Console.ReadLine());
        static double coordinateY4 = double.Parse(Console.ReadLine());

        static void Main(string[] args)
        {
            double lineOfFirstPair = FindHowLongIsTheLine(coordinateX1, coordinateY1, coordinateX2, coordinateY2);
            double lineOfSecondPair = FindHowLongIsTheLine(coordinateX3, coordinateY3, coordinateX4, coordinateY4);

            if (lineOfFirstPair >= lineOfSecondPair)
            {
                FindTheNearestCoordinates(coordinateX1, coordinateY1, coordinateX2, coordinateY2);
            }
            else
            {
                FindTheNearestCoordinates(coordinateX3, coordinateY3, coordinateX4, coordinateY4);
            }
        }

        static double FindHowLongIsTheLine(double x1, double y1, double x2, double y2)
        {
            double lineOfTwoCoordinates = (double)Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return lineOfTwoCoordinates;
        }

        static double FindDiagonal(double coordinateX, double coordinateY)
        {

            double diagonal = (double)Math.Sqrt((coordinateX * coordinateX) + (coordinateY * coordinateY));
            return diagonal;
        }

        static void FindTheNearestCoordinates(double x1, double y1, double x2, double y2)
        {
            if (FindDiagonal(x1, y1) <= FindDiagonal(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

    }
}
