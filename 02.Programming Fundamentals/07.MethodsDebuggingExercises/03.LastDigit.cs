using System;

class LastDigit
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(NameLastDigit(input));
    }
    static string NameLastDigit (string input)
    {
        if (input.EndsWith("0"))
        {
            return "zero";
        }
        else if (input.EndsWith("1"))
        {
            return "one";
        }
        else if (input.EndsWith("2"))
        {
            return "two";
        }
        else if (input.EndsWith("3"))
        {
            return "three";
        }
        else if (input.EndsWith("4"))
        {
            return "four";
        }
        else if (input.EndsWith("5"))
        {
            return "five";
        }
        else if (input.EndsWith("6"))
        {
            return "six";
        }
        else if (input.EndsWith("7"))
        {
            return "seven";
        }
        else if (input.EndsWith("8"))
        {
            return "eight";
        }
        else
        {
            return "nine";
        }
    }
}
