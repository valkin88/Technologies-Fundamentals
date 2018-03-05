using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool isItOdd = true;

            while (isItOdd)
            {
                string[] comandsForManipulation = Console.ReadLine().ToLower().Split(' ').ToArray();
                int[] argumentsAfterTheComand = new int[comandsForManipulation.Length];

                if (comandsForManipulation[0] == "odd")
                {
                    isItOdd = false;
                    FindTheOddNumbers(listOfIntegers);
                    break;
                }
                if (comandsForManipulation[0] == "delete")
                {
                    argumentsAfterTheComand[0] = int.Parse(comandsForManipulation[1]);

                    OperateDeleteAnElement(listOfIntegers, argumentsAfterTheComand);
                }
                if (comandsForManipulation[0] == "insert")
                {
                    argumentsAfterTheComand[0] = int.Parse(comandsForManipulation[1]);
                    argumentsAfterTheComand[1] = int.Parse(comandsForManipulation[2]);

                    OperateInsertAnElement(listOfIntegers, argumentsAfterTheComand);

                }
                else if (comandsForManipulation[0] == "even")
                {
                    isItOdd = false;
                    FindTheEvenNumbers(listOfIntegers);
                    break;
                }
            }
        }

        static void FindTheOddNumbers(List<int> listOfIntegers)
        {
            List<int> listOfOddNumbers = new List<int>();
            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] % 2 != 0)
                {
                    listOfOddNumbers.Add(listOfIntegers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", listOfOddNumbers));
        }

        static void FindTheEvenNumbers(List<int> listOfIntegers)
        {
            List<int> listOfEvenNumbers = new List<int>();
            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] % 2 == 0)
                {
                    listOfEvenNumbers.Add(listOfIntegers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", listOfEvenNumbers));
        }

        static void OperateDeleteAnElement(List<int> listOfIntegers, int[] args)
        {
            int numberToRemove = args[0];

            listOfIntegers.RemoveAll(x => x == numberToRemove);
        }

        static void OperateInsertAnElement(List<int> listOfIntegers, int[] args)
        {
            int elementForInserting = args[0];
            int indexWhereToInsert = args[1];

            listOfIntegers.Insert(indexWhereToInsert, elementForInserting);
        }
    }
}
