using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        //5 5 7 7 7 5 5
        var numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList<int>();
        var maxSequence = new List<int>();
        var currentSequence = new List<int>();
        var currentNumber = numbers[0];
        while (numbers.Count > 0)
        {
            if (numbers[0] != currentNumber)
            {
                if (currentSequence.Count > maxSequence.Count)
                {
                    maxSequence = currentSequence;
                }
                currentSequence = new List<int>();
                currentNumber = numbers[0];
            }
            currentSequence.Add(numbers[0]);
            numbers.RemoveAt(0);
        }
        if (currentSequence.Count > maxSequence.Count)
        {
            maxSequence = currentSequence;
        }
        Console.WriteLine(string.Join(" ", maxSequence));
    }
}
