using System;
using System.Collections.Generic;
using System.Linq;

class SortTimes
{
    static void Main()
    {
        var hours = Console.ReadLine().Split().ToList();
        hours.Sort();
        Console.WriteLine(string.Join (", ", hours));
    }
}

