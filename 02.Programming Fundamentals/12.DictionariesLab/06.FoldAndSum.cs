using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int take = numbers.Count / 2 / 2;
        var folded = numbers.Take(take).Reverse().ToList();
        numbers.RemoveRange(0, take);
        numbers.Reverse();
        folded.AddRange(numbers.Take(take));
        numbers.RemoveRange(0, take);
        numbers.Reverse();
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] += folded[i];
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}