using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Ladybugs
{


    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        List<int> indexesOfLadyBugs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> field = new List<int>();
        for (int i = 0; i < fieldSize; i++)
        {
            if (indexesOfLadyBugs.Contains(i))
            {
                field.Add(1);
            }
            else
            {
                field.Add(0);
            }
        }
        int count = fieldSize;

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] commands = input.Split(' ');
            int firstIndex = int.Parse(commands[0]);
            string direction = commands[1];
            int numberOfMovements = int.Parse(commands[2]);

            if (firstIndex >= 0 && firstIndex < count)
            {
                switch (direction)
                {
                    case "right": numberOfMovements = MoveRight(field, firstIndex, direction, numberOfMovements, count); break;
                    case "left": numberOfMovements = MoveLeft(field, firstIndex, direction, numberOfMovements, count); break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine(string.Join(" ", field));
    }

    
    private static int MoveLeft(List<int> field, int firstIndex, string direction, int numberOfMovements, int count)
    {
        if (numberOfMovements < 0)
        {
            numberOfMovements = Math.Abs(numberOfMovements);
            ShiftRight(field, firstIndex, numberOfMovements, count);
        }
        else
        {
            ShiftLeft(field, firstIndex, numberOfMovements, count);
        }

        return numberOfMovements;
    }

    private static int MoveRight(List<int> field, int firstIndex, string direction, int numberOfMovements, int count)
    {
        if (numberOfMovements < 0)
        {
            numberOfMovements = Math.Abs(numberOfMovements);
            ShiftLeft(field, firstIndex, numberOfMovements, count);
        }
        else
        {
            ShiftRight(field, firstIndex, numberOfMovements, count);
        }

        return numberOfMovements;
    }


    private static void ShiftRight(List<int> field, int firstIndex, int numberOfMovements, int count)
    {

        int index = firstIndex + numberOfMovements + 1;
        if (firstIndex + numberOfMovements < count && field[firstIndex] == 1)
        {
            if (numberOfMovements != 0)
            {
                for (int i = firstIndex + numberOfMovements; i < count; i += numberOfMovements)
                {
                    if (i < count && field[i] != 1)
                    {
                        field[i] = field[firstIndex];
                        field[firstIndex] = 0;
                    }
                    index += i;
                }
                if (index >= count)
                {
                    field[firstIndex] = 0;
                }
            }
            
        }
        else
        {
            field[firstIndex] = 0;
        }


    }

    private static void ShiftLeft(List<int> field, int firstIndex, int numberOfMovements, int count)
    {
       
        int index = firstIndex - numberOfMovements - 1;
        if (firstIndex - numberOfMovements >= 0 && field[firstIndex] == 1)
        {
            if (numberOfMovements != 0)
            {
                for (int i = firstIndex - numberOfMovements; i >= 0; i -= numberOfMovements)
                {
                    if (i >= 0 && field[i] != 1)
                    {
                        field[i] = field[firstIndex];
                        field[firstIndex] = 0;
                    }
                    index -= i;
                }
                if (index < 0)
                {
                    field[firstIndex] = 0;
                }
            }
        }
        else
        {
            field[firstIndex] = 0;
        }

    }
}

