using System;
using System.Linq;
using System.Collections.Generic;

namespace BePositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

                for (int i = 0; i < countSequences; i++)
                {
                    var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] numbersInput = input.Select(int.Parse).ToArray();

                    List<int> output = new List<int>();
                    int num = 0;
                    for (int j = 0; j < numbersInput.Length; j++)
                    {
                        if (numbersInput[j] >= 0)
                        {
                            num = numbersInput[j];
                            output.Add(num);
                        }
                        else if (j + 1 < numbersInput.Length)
                        {
                            num = numbersInput[j] + numbersInput[j + 1];
                            j++;
                            if (num >= 0)
                            {
                                output.Add(num);
                            }
                        }
                    }
                    if (output.Count() <= 0)
                    {
                        Console.WriteLine("(empty)");
                    }
                    else
                    {
                        foreach (var numbers in output)
                        {
                            Console.Write(numbers);
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
        }
    }
}
