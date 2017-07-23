using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurences
{
    static void Main()
    {
        var input = Console.ReadLine().ToLower().Split().ToList();
        var occurences = new Dictionary<string, int>();
        foreach (var word in input)
        {
            if (occurences.ContainsKey(word))
            {
                occurences[word]++;
            }
            else
            {
                occurences[word] = 1;
            }
        }
        var oddOccurences = occurences.Keys.Where(x => occurences[x] % 2 == 1);
        Console.WriteLine(string.Join(", ", oddOccurences));
    }
}
