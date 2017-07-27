using System;

class DivideWithoutRemainder
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) p1++;
            if (num % 3 == 0) p2++;
            if (num % 4 == 0) p3++;
        }
        p1 = p1 / n * 100;
        p2 = p2 / n * 100;
        p3 = p3 / n * 100;
        Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%", p1, p2, p3);
    }
}