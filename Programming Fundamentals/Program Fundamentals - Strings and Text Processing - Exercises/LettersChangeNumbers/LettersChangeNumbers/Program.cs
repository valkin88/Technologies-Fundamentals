using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LettersChangeNumbers
{
    class Program
    {

        public static string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
        public static string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<double> listOfNumbers = new List<double>();
            double action = 0.0;

            for (int i = 0; i < input.Length; i++)
            {

                string currentString = input[i].ToString().Trim();
                char firstLetter = currentString.First();
                char lastLetter = currentString.Last();
                double number = double.Parse(currentString.Remove(currentString.Length - 1).Substring(1));

                action = ActionWithFirstLetter(number, firstLetter);

                action = ActionWithLastLetter(action, lastLetter);

                listOfNumbers.Add(action);

            }
            double result = 0.0;
            foreach (var number in listOfNumbers)
            {
                result += number;
            }
            Console.WriteLine($"{result:f2}");
           
           
        }

        public static double ActionWithFirstLetter(double number, char firstLetter)
        {
            double action = 0.0;
            if (char.IsLower(firstLetter))
            {
                action = number * (alphabetLower.IndexOf(firstLetter) + 1);
            }
            else
            {
                action = number / (alphabetUpper.IndexOf(firstLetter) + 1);
            }
            return action;

        }

        public static double ActionWithLastLetter(double action, char lastLetter)
        {
            if (char.IsLower(lastLetter))
            {
                action += (alphabetLower.IndexOf(lastLetter) + 1);
            }
            else
            {
                action -= (alphabetUpper.IndexOf(lastLetter) + 1);
            }
            return action;
        }
    }
}
