using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int numberCount = 0;

            do
            {
                string num = Console.ReadLine();
                bool number = int.TryParse(num, out num1);
                numberCount++;

            }
            while (num1 != 0 && num1 % num1 == 0);
            Console.WriteLine(numberCount - 1);
        }
    }
}
