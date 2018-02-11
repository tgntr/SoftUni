using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem04
{
    class Problem04
    {
        static void Main()
        {
            var people = new Dictionary<string, Dictionary<string, string>>();
            var targetIndex = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end transmissions")
            {
                var data = input.Split(new string[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries);
                var name = data[0];

                if (!people.ContainsKey(name))
                {
                    people[name] = new Dictionary<string, string>();
                }
                for (int i = 1; i <= data.Length - 1; i++)
                {
                    var info = data[i].Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                    var infoKey = info[0];
                    var infoValue = info[1];
                    people[name][infoKey] = infoValue;
                }
                
            }

            var personToKill = Console.ReadLine().Split()[1];
            var personInfoIndex = people[personToKill].Sum(p => p.Key.Length + p.Value.Length);
            Console.WriteLine($"Info on {personToKill}:");
            foreach (var info in people[personToKill].OrderBy(p => p.Key))
            {
                Console.WriteLine($"---{info.Key}: {info.Value}");
            }
            Console.WriteLine($"Info index: {personInfoIndex}");
            if (personInfoIndex >= targetIndex)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                Console.WriteLine($"Need {targetIndex-personInfoIndex} more info.");
            }
        }
    }
}
