using System;
using System.Linq;

class LargestSequenceOfEqualElements
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        FindAndPrintLargestSequence(input);
    }
    static void FindAndPrintLargestSequence(string[] input)
    {
        string currentSequence = input[0] + ' ';
        string largestSequence = input[0] + ' ';
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                currentSequence += input[i + 1] + ' ';
            }
            else
            {
                if (currentSequence.Trim().Length > 1 && currentSequence.Trim().Length > largestSequence.Trim().Length)
                {
                    largestSequence = currentSequence.Trim();
                }
                currentSequence = input[i + 1] + ' ';
            }
            
        }
        if (currentSequence.Trim().Length > 1 && currentSequence.Trim().Length > largestSequence.Trim().Length)
        {
            largestSequence = currentSequence.Trim();
        }
        Console.WriteLine(largestSequence);
    }
}
