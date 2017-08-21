using System;

class SumOfTwoNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int magicNum = int.Parse(Console.ReadLine());
        int current = 0;
        bool found = false;
        for (int i = a; i <= b; i++)
        {
            for (int y = a; y <= b; y++)
            {
                current++;
                if (i + y == magicNum)
                {
                    found = true;
                    Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", current, i, y, magicNum);
                    break;
                }
            }
            if (found)
            {
                break;
            }
        }
        if (found == false)
        {
            Console.WriteLine("{0} combinations - neither equals {1}", current, magicNum);
        }
    }
}