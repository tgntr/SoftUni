using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

class SinoTheWalker
{
    static void Main()
    {
        var date = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
        var steps = long.Parse(Console.ReadLine()) % 86400;
        var secsPerStep = long.Parse(Console.ReadLine()) % 86400;
        long timeInSeconds = steps * secsPerStep;
        date = date.AddSeconds(timeInSeconds);
        Console.WriteLine($"Time Arrival: {date.ToString("HH:mm:ss")}");
    }
}