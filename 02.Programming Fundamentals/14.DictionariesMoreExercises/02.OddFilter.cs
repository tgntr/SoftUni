using System;
using System.Collections.Generic;
using System.Linq;

class OddFilter
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        numbers.RemoveAll(x => x % 2 == 1);
        double average = numbers.Average();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > average)
            {

                numbers[i]++;
            }
            else numbers[i]--;
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
