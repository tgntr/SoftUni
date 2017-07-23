using System;
using System.Collections.Generic;
using System.Linq;

class EnduranceRally
{
    static void Main()
    {
        var drivers = Console.ReadLine().Split(' ').ToArray();
        var path = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var safezones = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        foreach (var driver in drivers)
        {
            var finished = false;
            var fuel = (double) driver[0];
            for (int i = 0; i < path.Length; i++)
            {
                if (safezones.Contains(i))
                {
                    fuel += path[i];
                }
                else
                {
                    fuel -= path[i];
                }

                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {i}");
                    finished = true;
                    break;
                }
            }
            if (!finished)
            {
                Console.WriteLine($"{driver} - fuel left {fuel:f2}");
            }
        }
    }
}