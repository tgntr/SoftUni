using System;

class TwoNumbersSum
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int magic = int.Parse(Console.ReadLine());
        int combinations = 0;
        bool found = false;
        int a = 0;
        int b = 0;
        for (int i = first; i >= second; i--)
        {
            for (int y = first; y >= second; y--)
            {
                combinations++;
                if (i + y == magic)
                {
                    found = true;
                    a = i;
                    b = y;
                    break;
                }
            }
            if (found) break;
        }
        if (found) Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinations, a, b, magic);
        else Console.WriteLine("{0} combinations - neither equals {1}", combinations, magic);
    }
}