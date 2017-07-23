using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Legion
{
    public int LastActivity { get; set; }
    public string Name { get; set; }
    public Dictionary<string, long> Soldiers { get; set; }
}
class HornetArmada
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var inputPattern = new Regex(@"([\d]+) = ([^\-\s\=\>\:]+) -> ([^\-\s\=\>\:]+):([\d]+)");
        var legions = new List<Legion>();
        for (int i = 0; i < n; i++)
        {
            var matches = inputPattern.Match(Console.ReadLine());
            var lastActivity = int.Parse(matches.Groups[1].Value);
            var legionName = matches.Groups[2].Value;
            var soldierType = matches.Groups[3].Value;
            var soldierCount = int.Parse(matches.Groups[4].Value);
            if (!legions.Any(x=>x.Name == legionName))
            {
                legions.Add(new Legion
                {
                    Name = legionName,
                    LastActivity = lastActivity,
                    Soldiers = new Dictionary<string, long>(),
                    
                });
                legions.First(x=>x.Name == legionName).Soldiers[soldierType] = soldierCount;
            }
            else
            {
                var index = legions.FindIndex(x => x.Name == legionName);
                if (!legions[index].Soldiers.ContainsKey(soldierType))
                {
                    legions[index].Soldiers[soldierType] = soldierCount;
                }
                else
                {
                    legions[index].Soldiers[soldierType] += soldierCount;
                }
                if (lastActivity > legions[index].LastActivity)
                {
                    legions[index].LastActivity = lastActivity;
                }
            }
        }
        var input = Console.ReadLine();
        if (input.Contains("\\"))
        {
            var maxActivity = int.Parse(input.Split('\\')[0]);
            var soldier = input.Split('\\')[1];
            foreach (var legion in legions
                .Where(x=>x.LastActivity < maxActivity)
                .Where(x=>x.Soldiers.ContainsKey(soldier))
                .OrderByDescending(x=>x.Soldiers[soldier]))
            {
                Console.WriteLine($"{legion.Name} -> {legion.Soldiers[soldier]}");
            }
        }
        else
        {
            var soldier = input;
            foreach (var legion in legions.
                Where(x=>x.Soldiers.ContainsKey(soldier)).
                OrderByDescending(x=>x.LastActivity))
            {
                Console.WriteLine($"{legion.LastActivity} : {legion.Name}");
            }
        }
    }
}
