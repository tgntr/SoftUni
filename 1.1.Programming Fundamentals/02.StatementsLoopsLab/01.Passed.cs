using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        if (a >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }
    }
}

