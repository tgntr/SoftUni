using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(FibonacciNums(input));
    }
    static int FibonacciNums(int input)
    {
        int a = 0;
        int b = 1;
        int c = 1;
        for (int i = 1; i <= input; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;

    }
}
