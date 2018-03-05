using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class ExamProblemTwo
{
    static void Main()
    {
        string[] stringInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> listOfResult = new List<string>(stringInput);

        string input = Console.ReadLine();
        List<string> result = new List<string>();
        while (true)
        {

            if (input == "3:1")
            {
                break;
            }
            string[] commandsInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = commandsInput[0];
            switch (command)
            {
                case "merge": DoMerge(result, listOfResult, commandsInput); break;
                case "divide": DoDividing(result, listOfResult, commandsInput); break;
                default:
                    break;
            }
            input = Console.ReadLine();
        }
       foreach (var item in listOfResult)
       {
           Console.Write(item + " ");
       }
        Console.WriteLine();
    }

    private static void DoDividing(List<string> result, List<string> listOfResult, string[] commandsInput)
    {
        if (commandsInput.Length == 3)
        {
            result.Clear();
            int index = int.Parse(commandsInput[1]);
            int partitions = int.Parse(commandsInput[2]);
            string lastWord = String.Empty;
            string stringToTake = listOfResult[index];
            int divider = 0;
            if (stringToTake.Length % 2 == 0)
            {
                divider = stringToTake.Length / partitions;
            }
            else
            {
                divider = stringToTake.Length / (partitions - 1);
            }

            string pattern = $@"(.{{{divider}}})";
            Regex regex = new Regex(pattern);
            MatchCollection collection = regex.Matches(stringToTake);
            if (index == 0)
            {
                foreach (Match item in collection)
                {
                    result.Add(Convert.ToString(item.Groups[1]));
                }
                if (stringToTake.Length % partitions != 0)
                {
                    lastWord = result[result.Count - 1] + stringToTake[stringToTake.Length - 1];
                    result.RemoveAt(result.Count - 1);
                    result.Add(lastWord);

                }

            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    result.Add(listOfResult[i]);
                }
                foreach (Match item in collection)
                {
                    result.Add(Convert.ToString(item.Groups[1]));
                }
                if (listOfResult.Count % partitions != 0)
                {
                    lastWord = result[result.Count - 1] + stringToTake[stringToTake.Length - 1];
                    result.RemoveAt(result.Count - 1);
                    result.Add(lastWord);

                }
                for (int i = index + 1; i < listOfResult.Count; i++)
                {
                    result.Add(listOfResult[i]);
                }
            }
            listOfResult.Clear();
            foreach (var item in result)
            {
                listOfResult.Add(item);
            }
        }
       
    }

    private static void DoMerge(List<string> result, List<string> listOfResult, string[] commandsInput)
    {

        if (commandsInput.Length == 3)
        {
            result.Clear();
            int startIndex = int.Parse(commandsInput[1]);
            int endIndex = int.Parse(commandsInput[2]);
            string concatingStr = String.Empty;
            if (startIndex < listOfResult.Count)
            {
                if (startIndex <= 0 && endIndex < listOfResult.Count)
                {
                    for (int i = 0; i <= endIndex; i++)
                    {
                        concatingStr += listOfResult[i];
                    }
                    result.Add(concatingStr);
                    if (endIndex < listOfResult.Count)
                    {
                        for (int i = endIndex + 1; i < listOfResult.Count; i++)
                        {
                            result.Add(listOfResult[i]);
                        }
                    }

                }
                else if (startIndex > 0 && endIndex >= listOfResult.Count && startIndex < listOfResult.Count)
                {

                    for (int i = 0; i < startIndex; i++)
                    {
                        result.Add(listOfResult[i]);
                    }

                    if (startIndex < listOfResult.Count)
                    {
                        for (int i = startIndex; i < listOfResult.Count; i++)
                        {
                            concatingStr += listOfResult[i];
                        }
                        result.Add(concatingStr);
                    }

                }
                else if (startIndex > 0 && startIndex < listOfResult.Count && endIndex < listOfResult.Count)
                {
                    for (int i = 0; i < startIndex; i++)
                    {
                        result.Add(listOfResult[i]);
                    }
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concatingStr += listOfResult[i];
                    }
                    result.Add(concatingStr);
                    if (endIndex < listOfResult.Count - 1)
                    {
                        for (int i = endIndex + 1; i < listOfResult.Count; i++)
                        {
                            result.Add(listOfResult[i]);
                        }
                    }

                }
                else if ((startIndex <= 0 && endIndex >= listOfResult.Count) || (startIndex >= listOfResult.Count))
                {
                    for (int i = 0; i < listOfResult.Count; i++)
                    {
                        concatingStr += listOfResult[i];
                    }
                    result.Add(concatingStr);
                }
                listOfResult.Clear();
                foreach (var item in result)
                {
                    listOfResult.Add(item);
                }
            }

            
        }

    }
}

