using System;

class MakeWord
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = "";
        for (int i = 0; i < n; i++)
        {
            char input = Convert.ToChar(Console.ReadLine());
            word += input;
        }
        Console.WriteLine($"The word is: {word}");
    }
}
