using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
        numbers.RemoveAll(x => x < 0);
        numbers.Reverse();
        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
