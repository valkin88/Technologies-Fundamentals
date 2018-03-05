using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumbers = int.Parse(Console.ReadLine());
            int combinations = 0, firstNumber = 0, secondNumer = 0;
            var lastCombination = string.Empty;/// store LAST combination that is equal of the sum.
            for (firstNumber = n; firstNumber <= m; firstNumber++)
            {
                for (secondNumer = n; secondNumer <= m; secondNumer++)
                {
                    combinations++;

                    if (firstNumber + secondNumer == magicalNumbers && firstNumber > secondNumer)
                    {
                        lastCombination = $"Number found! {firstNumber} + {secondNumer} = {magicalNumbers}";

                    }
                }
            }

            if (lastCombination == string.Empty) /// checking if it is empty.
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNumbers}");
            }
            else /// if it is not empty then it has found the last combination.
            {
                Console.WriteLine(lastCombination);
            }
        }
    }
}
