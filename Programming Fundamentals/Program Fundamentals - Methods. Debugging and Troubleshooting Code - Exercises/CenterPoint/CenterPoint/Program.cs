using System;

namespace CenterPodouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double coordinateX1 = double.Parse(Console.ReadLine());
            double coordinateY1 = double.Parse(Console.ReadLine());
            double coordinateX2 = double.Parse(Console.ReadLine());
            double coordinateY2 = double.Parse(Console.ReadLine());

            double diagonalX1Y1 = FindDiagonal(coordinateX1, coordinateY1);

            double diagonalX2Y2 = FindDiagonal(coordinateX2, coordinateY2);

            if (diagonalX1Y1 <= diagonalX2Y2)
            {
                Console.WriteLine($"({coordinateX1}, {coordinateY1})");
            }
            else
            {
                Console.WriteLine($"({coordinateX2}, {coordinateY2})");
            }

            
        }

        static double FindDiagonal(double coordinateX, double coordinateY)
        {
            
            double diagonal = (double)Math.Sqrt((coordinateX * coordinateX) + (coordinateY * coordinateY));
            return diagonal;
        }
    }
}
