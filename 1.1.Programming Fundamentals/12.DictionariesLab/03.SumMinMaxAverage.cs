using System;
using System.Collections.Generic;
using System.Linq;
class SumMinMaxAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var numbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {(double)numbers.Average()}");

    }
}