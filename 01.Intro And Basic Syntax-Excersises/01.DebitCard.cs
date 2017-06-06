using System;

class DebitCard
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", a, b, c, d);
    }
}

