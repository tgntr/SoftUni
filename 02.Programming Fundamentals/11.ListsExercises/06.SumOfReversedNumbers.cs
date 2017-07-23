using System;
using System.Collections.Generic;
using System.Linq;

class SumReversedNumbers
{
    static void Main()
    {
        string input = Reverse(Console.ReadLine());
        var numbers = input.Split(' ').Select(int.Parse).ToList();
        Console.WriteLine(numbers.Sum());
    }
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
