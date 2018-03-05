using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int someNumber = int.Parse(Console.ReadLine());

            string intToHexadecimal = Convert.ToString(someNumber, 16).ToUpper();
            string intToBinary = Convert.ToString(someNumber, 2);
            Console.WriteLine(intToHexadecimal);
            Console.WriteLine(intToBinary);
        }
    }
}
