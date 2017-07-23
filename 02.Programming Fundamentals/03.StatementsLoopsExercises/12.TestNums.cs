using System;

class TestNums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int limit = int.Parse(Console.ReadLine());
        bool found = false;
        int sum = 0;
        int combinations = 0;
        for (int i = n; i >= 1; i--)
        {
            for (int y = 1; y <= m; y++)
            {
                combinations++;
                sum += (i * y) * 3;
                if (sum >= limit)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                break;
            }
        }
        Console.WriteLine("{0} combinations", combinations);
        if (found)
        {
            Console.WriteLine("Sum: {0} >= {1}", sum, limit);
        }
        else
        {
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
