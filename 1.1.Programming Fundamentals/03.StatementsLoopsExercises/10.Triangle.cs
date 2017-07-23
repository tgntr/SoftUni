using System;

class Triangle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int y = 1; y <= i; y++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
