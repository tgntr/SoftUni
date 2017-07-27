using System;
using System.Collections.Generic;
using System.Linq;

class HornetAssault
{
    static void Main()
    {
        ////hornets could be empty input
        var beehives = Console.ReadLine().Split().Select(long.Parse).Where(x => x > 0).ToList();
        var hornets = new List<long>();
        try
        {
            hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
        }
        catch (Exception) { }
        var currentHornet = 0;
        long totalDamage = hornets.Sum();
        for (int i = 0; i < beehives.Count; i++)
        {
            beehives[i] -= totalDamage;
            if (beehives[i] >= 0)
            {
                if (currentHornet == hornets.Count)
                {
                    break;
                }
                totalDamage -= hornets[currentHornet];
                hornets[currentHornet] = 0;
                currentHornet++;
            }
        }
        if (beehives.Any(x => x > 0))
        {
            Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets.Where(x => x > 0)));
        }
    }
}
