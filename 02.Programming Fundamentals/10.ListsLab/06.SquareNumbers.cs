using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Trim().Split(' ').Select(double.Parse).ToList<double>();
        numbers.Sort();
        numbers.Reverse();
        numbers.RemoveAll(x => Math.Sqrt(x) != (int)Math.Sqrt(x));
        Console.WriteLine(string.Join(" ", numbers));
    }
}