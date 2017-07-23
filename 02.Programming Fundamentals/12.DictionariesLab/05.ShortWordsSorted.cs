using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordsSorted
{
    static void Main()
    {
        char[] separators = new char[]{'.',',',':',';','(',')','[',']','"','\'', '\\','/','!','?',' '};
        var words = Console.ReadLine().ToLower().Split(separators).Where(x => x != "").ToList();
        var wordsLength = new SortedDictionary<string, int>();
        foreach (var word in words)
        {
            wordsLength[word] = word.Length;
        }
        var shortWords = wordsLength.Keys.Where(x => wordsLength[x] < 5).ToList();
        Console.WriteLine(string.Join(", ", shortWords));
    }
}
