using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int row = int.Parse(Console.ReadLine());
        for (int i = row; i <= 10; i++)
        {
            Console.WriteLine("{0} X {1} = {2}", n, i, n*i);
        }
        if (row > 10)
        {
            Console.WriteLine("{0} X {1} = {2}", n, row, n * row);
        }
    }
}

