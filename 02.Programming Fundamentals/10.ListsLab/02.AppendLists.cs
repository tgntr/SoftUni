using System;
using System.Collections.Generic;
using System.Linq;

class AppendLists
{
    static void Main()
    {
        var arrays = Console.ReadLine().Split('|').Select(d => d.Trim()).ToList<string>();
        
        arrays = arrays.Select(x => System.Text.RegularExpressions.Regex.Replace(x, @"\s+", " ")).ToList();
        arrays.Reverse();
        Console.WriteLine(string.Join(" ", arrays));
    }
}
