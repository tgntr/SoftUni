using System;

class StringConcatenation
{
    static void Main()
    {
        char delimiter = Convert.ToChar(Console.ReadLine());
        string oddOrEven = Console.ReadLine();
        int equals = 0;
        if (oddOrEven == "odd")
        {
            equals = 1;
        }
        int n = int.Parse(Console.ReadLine());
        string draw = "";
        for (int i = 1; i <= n; i++)
        {
            string input = Console.ReadLine();

            if (i < n - 1)
            {
                if (i % 2 == equals)
                {
                    draw += input + delimiter;
                }
            }
            else
            {
                if (i % 2 == equals)
                {
                    draw += input;
                }
            }
        }
        Console.WriteLine(draw);
    }
}
