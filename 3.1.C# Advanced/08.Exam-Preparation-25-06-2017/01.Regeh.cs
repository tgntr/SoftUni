using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Regeh
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var regehMatch = new Regex(@"\[[a-zA-Z]+\<([0-9]+)REGEH([0-9]+)\>[a-zA-Z]+\]");
        var matches = regehMatch.Matches(input);
        var numbers = new List<int>();

        foreach (Match match in matches)
        {
            numbers.Add(int.Parse(match.Groups[1].Value));
            numbers.Add(int.Parse(match.Groups[2].Value));
        }
        var currentIndex = 0;
        foreach (var number in numbers)
        {
            currentIndex += number;
            Console.Write(input[currentIndex % (input.Length - 1)]);
        }
    }
}
