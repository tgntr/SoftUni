using System;
using System.Collections.Generic;
using System.Linq;

class EqualSums
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            int leftSum = SumLeftSide(numbers, i);
            int rightSum = SumRightSide(numbers, i);
            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("no");
        }
    }
    static int SumLeftSide(int[]numbers, int index)
    {
        int sum = 0;
        for (int i = index - 1; i >= 0; i--)
        {
            if (i < 0)
            {
                break;
            }
            sum += numbers[i];
        }
        return sum;
    }
    static int SumRightSide(int[] numbers, int index)
    {
        int sum = 0;
        for (int i = index + 1; i < numbers.Length; i++)
        {
            if (i > numbers.Length - 1)
            {
                break;
            }
            sum += numbers[i];
        }
        return sum;
    }
}
