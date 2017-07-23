using System;
using System.Collections.Generic;
using System.Linq;
class LegendaryFarming
{
    static void Main()
    {
        var materials = new SortedDictionary<string, int>();
        materials["shards"] = 0;
        materials["fragments"] = 0;
        materials["motes"] = 0;
        var junk = new SortedDictionary<string, int>();
        bool itemObtained = materials.Values.Where(x => x >= 250).ToList().Count > 0;
        while (!itemObtained)
        {
            var farm = Console.ReadLine().ToLower().Split().ToList();
            for (int i = 0; i < farm.Count-1; i ++)
            {
                if (materials.ContainsKey(farm[i + 1]))
                {
                    materials[farm[i + 1]] += int.Parse(farm[i]);
                    if (materials[farm[i+1]] >= 250)
                    {
                        break;
                    }

                }
                else
                {
                    if (!junk.ContainsKey(farm[i+1]))
                    {
                        junk[farm[i + 1]] = int.Parse(farm[i]);
                    }
                    else
                    {
                        junk[farm[i + 1]] += int.Parse(farm[i]);
                    }
                }
                i++;
            }
            itemObtained = materials.Values.Where(x => x >= 250).ToList().Count > 0;
            if (itemObtained)
            {
                var item = materials.Keys.Where(x => materials[x] >= 250).ToList();
                if (materials["shards"] >= 250)
                {
                    materials["shards"] -= 250;
                    Console.WriteLine("Shadowmourne obtained!");
                }
                else if (materials["fragments"] >= 250)
                {
                    materials["fragments"] -= 250;
                    Console.WriteLine("Valanyr obtained!");
                }
                else
                {
                    materials["motes"] -= 250;
                    Console.WriteLine("Dragonwrath obtained!");

                }
            }
        }
        foreach (var material in materials.Keys.OrderByDescending(x => materials[x]))
        {
            Console.WriteLine($"{material}: {materials[material]}");
        }
        foreach (var material in junk.Keys)
        {
            Console.WriteLine($"{material}: {junk[material]}");
        }
    }
}
