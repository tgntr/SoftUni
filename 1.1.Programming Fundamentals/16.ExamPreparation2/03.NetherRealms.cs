using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class NetherRealms
{
    static void Main()
    {
        var demons = Console.ReadLine().Split(',').Select(x => x.Trim()).Where(x => !x.Contains(" ") && x != "").ToList();
        demons.Sort();
        foreach (var demon in demons)
        {
            var health = CalculateHealth(demon);
            var damage = CalculateDamage(demon);
            Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");
        }
    }
    static int CalculateHealth(string demon)
    {
        var healthCharactersPattern = new Regex(@"([^0-9/\-+*\.])+");
        var healthCharacters = string.Join("", (from Match m in healthCharactersPattern.Matches(demon) select m.Value).ToList());
        var health = 0;
        foreach (var character in healthCharacters)
        {
            health += character;
        }
        return health;
    }
    static decimal CalculateDamage(string demon)
    {
        var numbersPattern = new Regex(@"\-?[\d\.]+");
        var numbers = (from Match m in numbersPattern.Matches(demon) select m.Value).Select(decimal.Parse).ToList();
        var damage = 0m;
        foreach (var number in numbers)
        {
            damage += number;
        }
        var multipliersDivisorsPattern = new Regex(@"([*/])");
        var multipliersDivisors = (from Match m in multipliersDivisorsPattern.Matches(demon) select m.Value).ToList();
        foreach (var func in multipliersDivisors)
        {
            if (func == "*")
            {
                damage *= 2;
            }
            else
            {
                damage /= 2;
            }
        }
        return damage;
    }
}
