using System;

class SpeedUnits
{
    static void Main()
    {
        float meters = float.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());
        float mps = meters / ((hours * 60 * 60) + (minutes * 60) + seconds);
        float kmh = ((meters / 1000) * 60) / ((hours * 60) + minutes + (seconds / 60));
        float mph = ((meters / 1609) * 60) / ((hours * 60) + minutes + (seconds / 60));
        Console.WriteLine("{0} \n{1} \n{2}", mps, kmh, mph);
    }
}

