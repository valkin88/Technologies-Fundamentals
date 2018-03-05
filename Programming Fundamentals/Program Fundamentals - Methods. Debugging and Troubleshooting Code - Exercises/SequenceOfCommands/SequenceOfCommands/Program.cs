using System;
using System.Linq;

public class SequenceOfCommands_broken
{


    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {

        int sizeOfArray = int.Parse(Console.ReadLine());
        long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

        bool isItOver = true;
        while (isItOver)
        {
            string line = Console.ReadLine();

            string[] stringComandAndParams = line.Split(ArgumentsDelimiter);
            int[] args = new int[2];
            if (stringComandAndParams[0] == "stop")
            {
                isItOver = false;
                break;
            }
            if (stringComandAndParams[0] == "add" ||
                stringComandAndParams[0] == "subtract" ||
                stringComandAndParams[0] == "multiply")
            {

                args[0] = int.Parse(stringComandAndParams[1]);
                args[1] = int.Parse(stringComandAndParams[2]);

                PerformAction(array, stringComandAndParams[0], args);
            }
            else
            {
                PerformAction(array, stringComandAndParams[0], args);
            }


            PrintArray(array);
            Console.WriteLine();
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
        return arr;
    }

    private static void ArrayShiftRight(long[] array)
    {
        long lastNumberOfArray = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastNumberOfArray;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long lastNumberOfArray = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = lastNumberOfArray;
    }

    private static void PrintArray(long[] array)
    {
        foreach (var numberOfArray in array)
        {
            Console.Write(numberOfArray + " ");
        }
    }
}

