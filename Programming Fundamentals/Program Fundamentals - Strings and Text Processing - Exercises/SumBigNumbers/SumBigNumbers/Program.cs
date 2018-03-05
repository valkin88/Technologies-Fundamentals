using System;
using System.Text;
using System.Linq;

namespace SumBigNumbers
{
    public class Program
    {
        public static void Main()
        {
            string inputNumberOne = Console.ReadLine();
            string inputNumberTwo = Console.ReadLine();
            char padding = '0';

            if (inputNumberOne.Length < inputNumberTwo.Length)
            {
                inputNumberOne = inputNumberOne.PadLeft(inputNumberTwo.Length, padding);
            }
            else
            {
                inputNumberTwo = inputNumberTwo.PadLeft(inputNumberOne.Length, padding);
            }
            StringBuilder numberOne = new StringBuilder();
            numberOne.Append(inputNumberOne);
            StringBuilder numberTwo = new StringBuilder();
            numberTwo.Append(inputNumberTwo);

            StringBuilder resultReversed = new StringBuilder();
            StringBuilder result = new StringBuilder();

            int savedDigit = 0;
            int sum = 0;
            for (int i = numberOne.Length - 1; i >= 0; i--)
            {
                int digitOne = int.Parse(Convert.ToString(numberOne[i]));
                int digitTwo = int.Parse(Convert.ToString(numberTwo[i]));
                digitOne += savedDigit;
                sum = digitOne + digitTwo;
                if (digitOne + digitTwo > 9)
                {
                    resultReversed.Append(sum % 10);
                }
                else
                {
                    resultReversed.Append(sum);
                }
                savedDigit = sum / 10;

                if (i == 0 && savedDigit > 0)
                {
                    resultReversed.Append(savedDigit);
                }
            }
            Console.WriteLine(new string(resultReversed.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));

        }
    }
}
