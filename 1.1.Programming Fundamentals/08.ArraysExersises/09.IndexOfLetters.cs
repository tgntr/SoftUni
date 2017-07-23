using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        char[] letters = Console.ReadLine().ToCharArray();
        PrintLettersIndexes(letters);
    }
    static void PrintLettersIndexes(char[] letters)
    {
        char first = 'a';
        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine($"{letters[i]} -> {letters[i]-first}");
        }
    }
}
