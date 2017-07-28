using System;

class TomCat
{
    static void Main()
    {
        int holidays = int.Parse(Console.ReadLine());
        int playtime = (holidays * 127) + ((365 - holidays) * 63);
        int diff = Math.Abs(30000 - playtime);
        int hours = diff / 60;
        int mins = diff % 60;
        if (playtime <= 30000) Console.WriteLine("Tom sleeps well \n{0} hours and {1} minutes less for play", hours, mins);
        else Console.WriteLine("Tom will run away \n{0} hours and {1} minutes more for play", hours, mins);
    }
}
