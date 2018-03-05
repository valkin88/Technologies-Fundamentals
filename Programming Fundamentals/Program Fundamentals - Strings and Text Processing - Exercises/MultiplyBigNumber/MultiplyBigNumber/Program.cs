using System;
using System.Text;
using System.Linq;

namespace SumBigNumbers
{
    public class Program
    {
        public static void Main()
        {
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int savedDigit = 0;
            int multiply = 0;
            if (int.Parse(numberTwo) == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = numberOne.Length - 1; i >= 0; i--)
                {
                    int digitOne = int.Parse(Convert.ToString(numberOne[i]));
                    int digitTwo = int.Parse(Convert.ToString(numberTwo));
                    multiply = digitOne * digitTwo;
                    multiply += savedDigit;
                    if ((digitOne * digitTwo) + savedDigit > 9)
                    {
                        result.Append(multiply % 10);
                    }
                    else
                    {
                        result.Append(multiply);
                    }
                    savedDigit = multiply / 10;

                    if (i == 0 && savedDigit > 0)
                    {
                        result.Append(savedDigit);
                    }
                }
                Console.WriteLine(new string(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
            }

        }
    }
}