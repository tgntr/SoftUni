using System;
using System.Linq;

class AlphabeticalOrder
{
    static void Main()
    {
        char[] firstInput = Console.ReadLine().Split(' ').Select(Convert.ToChar).ToArray();
        char[] secondInput = Console.ReadLine().Split(' ').Select(Convert.ToChar).ToArray();
        bool[] alphabeticallyFirst = Alphabetically(firstInput, secondInput);
        PrintInAlphabeticalOrder(firstInput, secondInput, alphabeticallyFirst);

    }
    static bool[] Alphabetically(char[] firstinput, char[] secondInput)
    {
        bool[] alphabeticallyFirst = new bool[2];
        for (int i = 0; i < Math.Min(firstinput.Length, secondInput.Length); i++)
        {
            if (firstinput[i] < secondInput[i])
            {
                alphabeticallyFirst[0] = true;
                break;
            }
            else if (secondInput[i] < firstinput[i])
            {
                alphabeticallyFirst[1] = true;
                break;
            }
        }
        return alphabeticallyFirst;
    }
    static void PrintInAlphabeticalOrder(char[] firstInput, char[] secondInput, bool[] alphabeticallyFirst)
    {
        if (!alphabeticallyFirst[0] && !alphabeticallyFirst[1])
        {
            if (firstInput.Length < secondInput.Length)
            {
                PrintArray(firstInput);
                PrintArray(secondInput);
            }
            else
            {
                PrintArray(secondInput);
                PrintArray(firstInput);
            }
        }
        else
        {
            if (alphabeticallyFirst[0])
            {
                PrintArray(firstInput);
                PrintArray(secondInput);
            }
            else
            {
                PrintArray(secondInput);
                PrintArray(firstInput);
            }
        }
    }
    static void PrintArray(char[] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.Length; i++)
        {
            Console.Write(arrayToPrint[i]);
        }
        Console.WriteLine();
    }
}
