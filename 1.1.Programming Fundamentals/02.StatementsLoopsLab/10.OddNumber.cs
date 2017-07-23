using System;

class Program
{
    static void Main()
    {
        bool odd = false;
        while (odd == false)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            if (n % 2 == 1)
            {
                odd = true;
                Console.WriteLine("The number is: {0}",n);
            }
            else
            {
                Console.WriteLine("Please write an odd number.");
            }
        }
    }
}

