using System;

class CharacterStats
{
    static void Main()
    {
        string name = Console.ReadLine();
        int health = int.Parse(Console.ReadLine());
        int maxHealth = int.Parse(Console.ReadLine());
        int stamina = int.Parse(Console.ReadLine());
        int maxStamina = int.Parse(Console.ReadLine());
        string drawHealth = '|' + new string('|', health) + new string('.', maxHealth - health) + '|';
        string drawStamina = '|' + new string('|', stamina) + new string('.', maxStamina - stamina) + '|';
        Console.WriteLine("Name: {0} \nHealth: {1} \nEnergy: {2}", name, drawHealth, drawStamina);
    }
}

