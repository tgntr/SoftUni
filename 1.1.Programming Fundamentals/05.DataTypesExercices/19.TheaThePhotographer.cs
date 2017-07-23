using System;

class TheaThePhotographer
{
    static void Main()
    {
        long totalPics = long.Parse(Console.ReadLine());
        long filterTime = long.Parse(Console.ReadLine());
        double goodPercent = double.Parse(Console.ReadLine()) / 100;
        long uploadTime = long.Parse(Console.ReadLine());
        double goodPics = Math.Ceiling(totalPics * goodPercent);
        long filterTotal = totalPics * filterTime;
        long uploadTotal = (long)goodPics * uploadTime;
        long seconds = filterTotal + uploadTotal;
        long minutes = seconds / 60;
        seconds = seconds % 60;
        long hours = minutes / 60;
        minutes = minutes % 60;
        long days = hours / 24;
        hours = hours % 24;
        Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}