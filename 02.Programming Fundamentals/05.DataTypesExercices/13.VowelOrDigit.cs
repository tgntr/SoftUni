using System;

class VowelOrDigit
{
    static void Main()
    {
        string input = Console.ReadLine();
        bool found = false;
        try
        {
            int convert = int.Parse(input);
        }
        catch (FormatException)
        {
            found = true;
            if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
        if (found == false)
        {
            Console.WriteLine("digit");
        }

        
    }
}