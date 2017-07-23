using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniKaraoke
{
    static void Main()
    {
        var participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
        var songs = Console.ReadLine().Split(',').Select(x=>x.Trim()).ToList();
        var awards = new SortedDictionary<string, List<string>>();
        var input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
        while (input[0] != "dawn")
        {
            var participant = input[0];
            var song = input[1];
            var award = input[2];
            if (participants.Contains(participant) && songs.Contains(song))
            {
                if (!awards.ContainsKey(participant))
                {
                    awards[participant] = new List<string>();
                }
                if (!awards[participant].Contains(award))
                {
                    awards[participant].Add(award);
                }
            }
            input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
        }
        if (awards.Count == 0)
        {
            Console.WriteLine("No awards");
        }
        else
        {
            foreach (var participant in awards.Keys.OrderByDescending(x=>awards[x].Count))
            {
                Console.WriteLine($"{participant}: {awards[participant].Count} awards");
                foreach (var award in awards[participant].OrderBy(x=>x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
