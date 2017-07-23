using System;
using System.Collections.Generic;
using System.Linq;

class LargestThreeNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        numbers.Sort();
        numbers.Reverse();
        numbers = numbers.Take(3).ToList();
        Console.WriteLine(string.Join(" ", numbers));
    }
}
