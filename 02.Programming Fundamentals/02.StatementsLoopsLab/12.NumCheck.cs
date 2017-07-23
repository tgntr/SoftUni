using System;

class Program
{
    static void Main()
    {
        bool caught = false;
        try
        {
            int n = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
            caught = true;
        }
        if (caught == false)
        {
            Console.WriteLine("It is a number.");
        }

    }
}
