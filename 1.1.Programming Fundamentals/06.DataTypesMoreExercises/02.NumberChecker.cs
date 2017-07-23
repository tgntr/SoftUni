using System;

class NumberChecker
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        if (input > Math.Floor(input))
        {
            Console.WriteLine("floating-point");
        }
        else
        {
            Console.WriteLine("integer");
        }
    }
}
