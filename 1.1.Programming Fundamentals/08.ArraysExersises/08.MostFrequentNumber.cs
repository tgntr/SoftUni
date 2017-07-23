using System;

class MostFrequentNumber
{
    static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split(' ');
        int[] numberFrequency = new int[input.Length];
        bool[] numberIsChecked = new bool[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (!numberIsChecked[i])
            {
                numberIsChecked = CheckNumbers(input, i);
                numberFrequency[i] = CountNumberFrequency(input, i);
            }
        }
        PrintMostFrequentNumber(numberFrequency, input);
    }
    static bool[] CheckNumbers (string[] input, int i)
    {
        bool[] numberIsChecked = new bool[input.Length];
        for (int y = i; y < input.Length; y++)
        {
            if (input[i] == input[y])
            {
                numberIsChecked[i] = true;
            }

        }
        return numberIsChecked;
    }
    static int CountNumberFrequency(string[] input, int i)
    {
        int count = 0;
        for (int y = i; y < input.Length; y++)
        {
            if (input[i] == input[y])
            {
                count++;
            }

        }
        return count;
    }
    static void PrintMostFrequentNumber(int[] numbersFrequency, string[] input)
    {
        int mostFrequentIndex = 0;
        for (int i = 1; i < numbersFrequency.Length; i++)
        {
            if (numbersFrequency[i] > numbersFrequency[mostFrequentIndex])
            {
                mostFrequentIndex = i;
            }
        }
        Console.WriteLine(input[mostFrequentIndex]);
    }
}
