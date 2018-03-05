using System;

namespace NumbersInReversedOrder
{
    class Program
    {

        static string printedNumber = Console.ReadLine();

        public static string PrintingReverseNumber(string printedNumber)
        {
            string result = "";

            for (int i = printedNumber.Length - 1; i >= 0; i--)
            {
                result += printedNumber[i]; 
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PrintingReverseNumber(printedNumber));
        }
    }
}
