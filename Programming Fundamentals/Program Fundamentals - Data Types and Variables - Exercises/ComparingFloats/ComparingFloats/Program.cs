using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstFloatingPointNumber = double.Parse(Console.ReadLine());
            double secondFloatingPointNumber = double.Parse(Console.ReadLine());
            double resultOftwoNumbers = Math.Abs(firstFloatingPointNumber - secondFloatingPointNumber);
            if (resultOftwoNumbers >= 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
