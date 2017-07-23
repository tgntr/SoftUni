using System;

class DecryptingMessages
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string draw = "";
        for (int i = 0; i < n; i++)
        {
            char input = Convert.ToChar(Console.ReadLine());
            int element = Convert.ToInt32(input);
            input = (char)(element + key);
            draw += input;
        }
        Console.WriteLine(draw);
    }
}
