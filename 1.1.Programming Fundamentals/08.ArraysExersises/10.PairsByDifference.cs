using System;
using System.Collections.Generic;
using System.Linq;

class PairsByDifference
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());
        CountPairsByDifference(numbers, difference);
    }
    static void CountPairsByDifference(int[] numbers, int difference)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length-1; i++)
        {
            for (int y = i; y < numbers.Length; y++)
            {
                if (Math.Abs(numbers[i]-numbers[y]) == difference)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
