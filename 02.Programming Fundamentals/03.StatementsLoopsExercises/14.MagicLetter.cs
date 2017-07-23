using System;

class MagicLetters
{
    static void Main()
    {
        char firstLetter = Convert.ToChar(Console.ReadLine());
        char secondLetter = Convert.ToChar(Console.ReadLine());
        char forbiddenLetter = Convert.ToChar(Console.ReadLine());
        int a = Convert.ToInt32(firstLetter);
        int b = Convert.ToInt32(secondLetter);
        int c = Convert.ToInt32(forbiddenLetter);
        for (int i = a; i <= b; i++)
        {
            if (i == c)
            {
                continue;
            }
            for (int y = a; y <= b; y++)
            {
                if (y == c)
                {
                    continue;
                }
                for (int z = a; z <= b; z++)
                {
                    if (z == c)
                    {
                        continue;
                    }
                    Console.Write("{0}{1}{2} ", (char)i, (char)y, (char)z);
                    
                }
                
            }
            
        }
    }
}
