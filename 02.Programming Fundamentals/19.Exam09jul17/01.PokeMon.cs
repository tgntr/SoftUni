using System;
using System.Collections.Generic;
using System.Linq;

class PokeMon
{
    static void Main()
    {
        var power = decimal.Parse(Console.ReadLine());
        var distance = decimal.Parse(Console.ReadLine());
        var exhaustion = decimal.Parse(Console.ReadLine());
        var pokesCount = 0;
        var currentPower = power;
        var halfOfPower = 0.5m * power;
        while (currentPower >= distance)
        {
            pokesCount++;
            currentPower -= distance;
            
            if (currentPower == halfOfPower)
            {
                if (currentPower >= exhaustion && exhaustion != 0)
                {
                    currentPower = (long)(currentPower/exhaustion);
                }
            }
        }
        Console.WriteLine(currentPower);
        Console.WriteLine(pokesCount);
    }
}
