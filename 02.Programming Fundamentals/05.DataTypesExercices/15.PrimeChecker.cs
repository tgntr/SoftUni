using System;

class PrimeChecker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            bool prime = true;
            for (int y = 2; y <= Math.Sqrt(i); y++)
            {
                if (i % y == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {prime}");
        }

    }
}
