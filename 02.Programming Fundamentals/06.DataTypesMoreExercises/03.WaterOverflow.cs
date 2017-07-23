using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int litersLimit = 255;
        for (int i = 0; i < input; i++)
        {
            int waterToPour = int.Parse(Console.ReadLine());
            if (waterToPour > litersLimit)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                litersLimit -= waterToPour;
            }
        }
        Console.WriteLine(255 - litersLimit);
    }
}
