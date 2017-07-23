using System;
using System.Collections.Generic;
using System.Linq;

class HornetWings
{
    static void Main()
    {
        //used calculator to see that they want flaps/endurance without the floating point
        var flaps = decimal.Parse(Console.ReadLine());
        var distance = decimal.Parse(Console.ReadLine());
        var endurance = decimal.Parse(Console.ReadLine());
        var totaldistance = (flaps / 1000) * distance;
        var totalTimeInSeconds = flaps / 100;
        totalTimeInSeconds += (long)(flaps / endurance) * 5;
        Console.WriteLine($"{totaldistance:F2} m. \n{totalTimeInSeconds} s.");
     }
}
