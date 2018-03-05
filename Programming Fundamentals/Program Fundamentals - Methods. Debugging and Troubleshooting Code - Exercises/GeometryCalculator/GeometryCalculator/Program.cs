using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine().ToLower();

            switch (typeOfFigure)
            {
                case "triangle": CalculateAreaOfTriangle(); break;
                case "square": CalculateAreaOfSquare(); break;
                case "rectangle": CalculateAreaOfRectangle(); break;
                case "circle": CalculateAreaOfCircle(); break;
                default:
                    break;
            }
        }

        static void CalculateAreaOfTriangle()
        {
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double heightOfTriangle = double.Parse(Console.ReadLine());

            double areaOfTriangle = (sideOfTriangle * heightOfTriangle) / 2;

            Console.WriteLine($"{areaOfTriangle:f2}");
        }

        static void CalculateAreaOfSquare()
        {
            double sideOfSquare = double.Parse(Console.ReadLine());

            double areaOfSquare = sideOfSquare * sideOfSquare;

            Console.WriteLine($"{areaOfSquare:f2}");
        }

        static void CalculateAreaOfRectangle()
        {
            double widthOfRectangle = double.Parse(Console.ReadLine());
            double heightOfRectangle = double.Parse(Console.ReadLine());

            double areaOfRectangle = widthOfRectangle * heightOfRectangle;

            Console.WriteLine($"{areaOfRectangle:f2}");
        }

        static void CalculateAreaOfCircle()
        {
            double radiusOfCircle = double.Parse(Console.ReadLine());

            double areaOfCircle = Math.PI * radiusOfCircle * radiusOfCircle;

            Console.WriteLine($"{areaOfCircle:f2}");
        }
    }
}
