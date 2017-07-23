using System;

class SMS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string draw = "";
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            int formula = (((int)Char.GetNumericValue(input[0]) - 2) * 3) + (input.Length - 1);
            if (input[0] > '7')
            {
                formula++;
            }
            if (input[0] == '0')
            {
                draw += ' ';
            }
            else
            {
                draw += (char)(int)('a' + formula);
            }
        }
        Console.WriteLine(draw);
    }
}
