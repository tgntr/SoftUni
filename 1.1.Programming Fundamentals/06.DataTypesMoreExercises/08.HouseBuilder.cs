using System;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long sbytePrice = 0;
        long intPrice = 0;
        if (a > sbyte.MaxValue)
        {
            intPrice = a;
            sbytePrice = b;
        }
        else if (b> sbyte.MaxValue)
        {
            intPrice = b;
            sbytePrice = a;
        }
        long totalPrice = (sbytePrice * 4) + (intPrice * 10);
        Console.WriteLine(totalPrice);
    }
}
