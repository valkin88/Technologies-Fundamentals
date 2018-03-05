using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool isItOver = true;
            while (isItOver)
            {
                string[] commandsForManipulation = Console.ReadLine().ToLower().Split(' ').ToArray();
                int[] argumentsAfterTheComand = new int[commandsForManipulation.Length - 1];
                int index = 0;
                for (int i = 1; i < commandsForManipulation.Length; i++)
                {
                    argumentsAfterTheComand[index] = int.Parse(commandsForManipulation[i]);
                    index++;
                }
                if (commandsForManipulation[0] == "print")
                {
                    isItOver = false;
                    break;
                }
                switch (commandsForManipulation[0])
                {
                    case "add": AddingANumberInTheList(listOfIntegers, argumentsAfterTheComand); break;
                    case "addmany": AddManyItemsInList(listOfIntegers, argumentsAfterTheComand); break;
                    case "contains": DoesItContainASpecificElement(listOfIntegers, argumentsAfterTheComand); break;
                    case "remove":
                        int indexToRemove = int.Parse(commandsForManipulation[1]);

                        listOfIntegers.RemoveAt(indexToRemove);
                        break;
                    case "shift": ShiftTheListToTheLeft(listOfIntegers, argumentsAfterTheComand); break;
                    case "sumpairs": SumPairsInAList(listOfIntegers); break;

                }
            }
            Console.WriteLine("[" + string.Join(", ", listOfIntegers) + "]");
        }

        private static void AddManyItemsInList(List<int> listOfIntegers, int[] argumentsAfterTheCommand)
        {
            int index = argumentsAfterTheCommand[0];
            List<int> listOfNumbersAfterTheCommand = new List<int>(argumentsAfterTheCommand);
            listOfNumbersAfterTheCommand.Remove(listOfNumbersAfterTheCommand[0]);

            listOfIntegers.InsertRange(index, listOfNumbersAfterTheCommand);
        }

        static void AddingANumberInTheList(List<int> listOfIntegers, int[] argumentsAfterTheCommand)
        {
            int elementForAdding = argumentsAfterTheCommand[1];
            int indexWhereToAdd = argumentsAfterTheCommand[0];

            listOfIntegers.Insert(indexWhereToAdd, elementForAdding);
        }

        static void DoesItContainASpecificElement(List<int> listOfIntegers, int[] argumentsAfterTheCommand)
        {
            int specificNumber = argumentsAfterTheCommand[0];

            if (listOfIntegers.Contains(specificNumber))
            {
                Console.WriteLine(listOfIntegers.IndexOf(specificNumber));
                    
            }
            else
            {
                Console.WriteLine(-1);
            }

        }

        static void ShiftTheListToTheLeft(List<int> listOfIntegers, int[] argumentsAfterTheCommand)
        {
            int countToShift = argumentsAfterTheCommand[0];

            for (int i = 0; i < countToShift; i++)
            {
                int lastNumberOfArray = listOfIntegers[0];
                for (int j = 0; j < listOfIntegers.Count - 1; j++)
                {
                    listOfIntegers[j] = listOfIntegers[j + 1];
                }
                listOfIntegers[listOfIntegers.Count - 1] = lastNumberOfArray;
            }

        }

        static void SumPairsInAList(List<int> listOfIntegers)
        {
            List<int> listOfSumPairs = new List<int>();
            if (listOfIntegers.Count % 2 == 0)
            {
                for (int i = 0; i < listOfIntegers.Count; i += 2)
                {
                    listOfIntegers[i] += listOfIntegers[i + 1];
                    listOfSumPairs.Add(listOfIntegers[i]);
                }
                listOfIntegers.Clear();
                foreach (var item in listOfSumPairs)
                {
                    listOfIntegers.Add(item);
                }
            }
            else
            {
                int lastNumberInList = listOfIntegers[listOfIntegers.Count - 1];
                listOfIntegers.Remove(listOfIntegers[listOfIntegers.Count - 1]);
                for (int i = 0; i < listOfIntegers.Count; i += 2)
                {
                    listOfIntegers[i] += listOfIntegers[i + 1];
                    listOfSumPairs.Add(listOfIntegers[i]);
                }
                listOfIntegers.Clear();
                foreach (var item in listOfSumPairs)
                {
                    listOfIntegers.Add(item);
                }
                listOfIntegers.Add(lastNumberInList);
            }
        }
    }
}
