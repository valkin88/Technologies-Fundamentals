using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthOfRectangle = double.Parse(Console.ReadLine());
            double heightOfRectangle = double.Parse(Console.ReadLine());

            double perimeterOfRectangle = 2 * (widthOfRectangle + heightOfRectangle);
            double areaOfRectangle = widthOfRectangle * heightOfRectangle;
            double diagonalOfRectangle = Math.Sqrt((widthOfRectangle * widthOfRectangle) + (heightOfRectangle * heightOfRectangle));

            Console.WriteLine(perimeterOfRectangle);
            Console.WriteLine(areaOfRectangle);
            Console.WriteLine(diagonalOfRectangle);
        }
    }
}
