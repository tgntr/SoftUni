using System;
using System.Collections.Generic;
using System.Linq;
class CountRealNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        var occurencies = new SortedDictionary<double, int>();
        foreach (var item in numbers)
        {
            if (occurencies.ContainsKey(item))
            {
                occurencies[item]++;
            }
            else
            {
                occurencies[item] = 1;
            }
        }
        foreach (var key in occurencies.Keys)
        {
            Console.WriteLine($"{key} -> {occurencies[key]}");
        }
    }
}
