using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class CharityMarathon
{
    static void Main()
    {
        var days = decimal.Parse(Console.ReadLine());
        var runners = decimal.Parse(Console.ReadLine());
        var laps = decimal.Parse(Console.ReadLine());
        var length = decimal.Parse(Console.ReadLine());
        var capacity = decimal.Parse(Console.ReadLine());
        var moneyPerKm = decimal.Parse(Console.ReadLine());
        if (runners > capacity * days)
        {
            runners = capacity * days;
        }
        var totalKilometers = (runners * laps * length) / 1000m;
        var totalMoney = totalKilometers * moneyPerKm;
        Console.WriteLine($"Money raised: {totalMoney:F2}");
    }
}

