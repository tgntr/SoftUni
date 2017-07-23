using System;
using System.Collections.Generic;
using System.Linq;

class SearchNumber
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
        var parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
        var firstElements = numbers.Take(parameters[0]).ToList();
        firstElements.RemoveRange(0, parameters[1]);
        bool containsRequiredElement = firstElements.Any(x => x == parameters[2]);
        if (containsRequiredElement)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}
