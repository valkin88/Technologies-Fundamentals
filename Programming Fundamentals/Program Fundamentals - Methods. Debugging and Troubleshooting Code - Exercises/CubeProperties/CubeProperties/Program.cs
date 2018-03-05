using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameterofCube = Console.ReadLine().ToLower();

            switch (parameterofCube)
            {
                case "face": ReturnFaceDiagonalOfCube(sideOfCube); break;
                case "space": ReturnSpaceDiagonalsOfCube(sideOfCube); break;
                case "volume": ReturnVolumeOfCube(sideOfCube); break;
                case "area": ReturnnSurfaceAreaOfCube(sideOfCube); break;
                default:
                    break;
            }
        }

        static void ReturnFaceDiagonalOfCube(double side)
        {
            double faceDiagonalOfCube = (double)Math.Sqrt(2 * (side * side));

            Console.WriteLine($"{faceDiagonalOfCube:f2}");
        }

        static void ReturnSpaceDiagonalsOfCube(double side)
        {
            double spaceDiagonalOfCube = (double)Math.Sqrt(3 * (side * side));

            Console.WriteLine($"{spaceDiagonalOfCube:f2}");
        }

        static void ReturnVolumeOfCube(double side)
        {
            double volumeOfCube = side * side * side;

            Console.WriteLine($"{volumeOfCube:f2}");
        }

        static void ReturnnSurfaceAreaOfCube(double side)
        {
            double surfaceAreaOfCube = 6 * (side * side);

            Console.WriteLine($"{surfaceAreaOfCube:f2}");
        }
    }
}
