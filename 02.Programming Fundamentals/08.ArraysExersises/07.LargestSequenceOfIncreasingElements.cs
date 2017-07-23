using System;
using System.Collections.Generic;
using System.Linq;

class LargestSequenceOfEqualElements
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        FindAndPrintLargestSequence(input);
    }
    static void FindAndPrintLargestSequence(int[] input)
    {
        List<int> currentSequence = new List<int>();
        List<int> largestSequence = new List<int>();
        currentSequence.Add(input[0]);
        largestSequence.Add(input[0]);
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] < input[i + 1])
            {
                currentSequence.Add(input[i + 1]);
            }
            else
            {
                if (currentSequence.Count > largestSequence.Count)
                {
                    largestSequence = currentSequence;
                }
                currentSequence = new List<int>();
                currentSequence.Add(input[i + 1]);
            }
        }
        if (currentSequence.Count > largestSequence.Count)
        {
            largestSequence = currentSequence;
        }
        PrintArray(largestSequence);
    }
    static void PrintArray(List<int> largestSequence)
    {
        for (int i = 0; i < largestSequence.Count; i++)
        {
            if (i == largestSequence.Count - 1)
            {
                Console.Write(largestSequence[i]);
            }
            else
            {
                Console.Write(largestSequence[i] + " ");
            }
        }
    }
}