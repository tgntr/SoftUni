using System;
using System.Collections.Generic;
using System.Linq;

class MinerTask
{
    static void Main()
    {
        var resources = new Dictionary<string, int>();
        string input = Console.ReadLine();
        string resource = "";
        int quantity = 0;
        int inputCount = 1;
        while (input != "stop")
        {
            if (inputCount % 2 == 1)
            {
                resource = input;
            }
            else
            {
                quantity = int.Parse(input);
                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources[resource] = quantity;
                }
            }
            input = Console.ReadLine();
            inputCount++;
        }
        foreach (var metal in resources.Keys)
        {
            Console.WriteLine($"{metal} -> {resources[metal]}");
        }
    }
}
