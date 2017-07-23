using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        //Console.WriteLine("Before: \na = {0} \nb = {1} \nAfter: \na = {2} \nb = {3}", a, b, b, a);
        int save = a;
        Console.WriteLine("Before: \na = {0} \nb = {1}", a, b);
        a = b;
        b = save;
        Console.WriteLine("After: \na = {0} \nb = {1}", a, b);

    }
}
