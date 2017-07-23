using System;
using System.Collections.Generic;
using System.Linq;

class ImmuneSystem
{
    static void Main()
    {
        int health = int.Parse(Console.ReadLine());
        int initialHealth = health;
        var viruses = new Dictionary<string, int>();
        var virusesTime = new Dictionary<string, int>();
        string input = Console.ReadLine();
        while (input != "end")
        {
            if (!viruses.ContainsKey(input))
            {
                viruses[input] = CalculateVirusStrength(input);
                virusesTime[input] = viruses[input] * input.Length;
            }
            else
            {
                virusesTime[input] /= 3;
            }
            health -= virusesTime[input];
            if (health > 0)
            {
                Console.WriteLine($"Virus {input}: {viruses[input]} => {virusesTime[input]} seconds");
                Console.WriteLine($"{input} defeated in {virusesTime[input] / 60}m {virusesTime[input] % 60}s.");
                Console.WriteLine($"Remaining health: {health}");
                health += (int)(0.2d * health);
                if (health > initialHealth)
                {
                    health = initialHealth;
                }
            }
            else
            {
                Console.WriteLine($"Virus {input}: {viruses[input]} => {virusesTime[input]} seconds");
                Console.WriteLine("Immune System Defeated.");
                break;
            }
            input = Console.ReadLine();
            if (input == "end")
            {
                Console.WriteLine($"Final Health: {health}");
            }
        }
    }
    static int CalculateVirusStrength(string input)
    {
        int strength = 0;
        char[] elements = input.ToCharArray();
        for (int i = 0; i < elements.Length; i++)
        {
            strength += elements[i];
        }
        return strength / 3;
    }
}
