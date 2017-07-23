using System;

class SumOddNums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(num);
            sum += num;
            num += 2;
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}

