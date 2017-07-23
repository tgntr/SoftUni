using System;

class ThirtyMins
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int mins = int.Parse(Console.ReadLine());
        mins += 30;
        if (mins>= 60)
        {
            hours += mins / 60;
            mins = mins % 60;
        }
        if (hours > 23)
        {
            hours = (hours-1) - 23;
        }
        Console.WriteLine("{0}:{1:D2}", hours, mins);
    }
}

