using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing
{
    static void Main()
    {
        var words = Console.ReadLine().Split(',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ').ToList<string>();
        words.RemoveAll(x => x == "");
        var lowerCase = new List<string>();
        var mixedCase = new List<string>();
        var upperCase = new List<string>();
        for (int i = 0; i < words.Count; i++)
        {
            if (!words[i].All(Char.IsLetter))
            {
                mixedCase.Add(words[i]);
            }
            else if (words[i].ToLower() == words[i])
            {
                lowerCase.Add(words[i]);
            }
            else if (words[i].ToUpper() == words[i])
            {
                upperCase.Add(words[i]);
            }
            else
            {
                mixedCase.Add(words[i]);
            }
        }
        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
    }
}