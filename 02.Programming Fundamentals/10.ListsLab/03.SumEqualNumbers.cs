using System;
using System.Collections.Generic;
using System.Linq;

class SumEqualNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList<double>();
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i];
                numbers.RemoveAt(i+1);
                i = -1;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
