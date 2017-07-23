using System;
using System.Linq;

public class SequenceOfCommands
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] numbers = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = "";

        while (!command.Split(ArgumentsDelimiter)[0].Equals("stop"))
        {
            command = Console.ReadLine().Trim();
            if (command.Split(ArgumentsDelimiter)[0].Equals("stop"))
            {
                break;
            }
            int[] args = new int[2];

            if (command.Split(ArgumentsDelimiter).Length > 1)
            {
                string[] stringParams = command.Split(ArgumentsDelimiter);
                args[0] = int.Parse(stringParams[1]) - 1;
                args[1] = int.Parse(stringParams[2]);

                //PerformAction(numbers, command.Split(ArgumentsDelimiter)[0], args);
            }

            numbers = PerformAction(numbers, command.Split(ArgumentsDelimiter)[0], args);
            PrintArray(numbers);
        }
    }

    static long [] PerformAction(long[] numbers, string action, int[] args)
    {
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                numbers[pos] *= value;
                break;
            case "add":
                numbers[pos] += value;
                break;
            case "subtract":
                numbers[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(numbers);
                break;
            case "rshift":
                ArrayShiftRight(numbers);
                break;
        }
        return numbers;
    }

    private static void ArrayShiftRight(long[] numbers)
    {
        long save = numbers[numbers.Length - 1];
        for (int i = numbers.Length - 1; i > 0; i--)
        {
            numbers[i] = numbers[i-1];
        }
        numbers[0] = save;
    }

    private static void ArrayShiftLeft(long[] numbers)
    {
        long save = numbers[0];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            numbers[i] = numbers[i+1];
        }
        numbers[numbers.Length - 1] = save;
    }

    private static void PrintArray(long[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
