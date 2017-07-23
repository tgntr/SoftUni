using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            char input = Convert.ToChar(Console.ReadLine());
            sum += Convert.ToInt32(input);
        }
        Console.WriteLine($"The sum equals: {sum}");
    }
}
