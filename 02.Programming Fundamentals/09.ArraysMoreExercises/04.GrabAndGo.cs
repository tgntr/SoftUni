using System;
using System.Collections.Generic;
using System.Linq;

class GrabAndGo
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int magicNumber = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = input.Length-1; i >= 0; i--)
        {
            long sum = 0;
            if (input[i] == magicNumber)
            {
                sum = SumOfNumbers(input, i);
                Console.WriteLine(sum);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("No occurrences were found!");
        }
    }
    static long SumOfNumbers(int[] input, int index)
    {
        long sum = 0;
        if (index == 0)
        {
            return sum;
        }
        for (int i = index - 1; i >= 0; i--)
        {
            sum += input[i];
        }
        return sum;
    }
}
