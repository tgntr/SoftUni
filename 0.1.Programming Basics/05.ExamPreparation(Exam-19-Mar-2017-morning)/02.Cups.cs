using System;

class Cups
{
    static void Main()
    {
        int planned = int.Parse(Console.ReadLine());
        int employees = int.Parse(Console.ReadLine());
        int workDays = int.Parse(Console.ReadLine());
        int totalHours = employees * 8 * workDays;
        int totalCups = totalHours / 5;
        if (totalCups < planned) Console.WriteLine("Losses: {0:F2}", (planned - totalCups) * 4.2d);
        else Console.WriteLine("{0:F2} extra money ", (totalCups - planned) * 4.2d);
    }
}