using System;

class GameOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicNum = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 0;
        int combinations = 0;
        for (int i = n; i <= m; i++)
        {
            for (int y = n; y <= m; y++)
            {
                combinations++;
                if (i + y == magicNum)
                {
                    a = i;
                    b = y;
                }
            }

        }
        if (a == 0)
        {
            Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicNum);
        }
        else
        {
            Console.WriteLine("Number found! {0} + {1} = {2}", a, b, magicNum);
        }

    }
}

