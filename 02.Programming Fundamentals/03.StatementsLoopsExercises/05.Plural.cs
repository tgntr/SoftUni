using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        if (input.EndsWith("y"))
        {
            input = input.Remove(input.Length - 1);
            input += "ies";

        }
        else if (input.EndsWith("o") || input.EndsWith("ch") || input.EndsWith("s") || 
            input.EndsWith("sh") || input.EndsWith("x") || input.EndsWith("z"))
        {
            input += "es";
        }
        else
        {
            input += "s";
        }
        Console.WriteLine(input);
    }
}
