using System;

public class Warrior
    : Character, IAttackable
{
    public Warrior(string name, Faction faction)
        : base(name, 100, 50, 40, BagFactory.CreateBag("Satchel"), faction)
    {

    }

    public void Attack(Character character)
    {
        CheckIfAlive();
        character.CheckIfAlive();
        if (this == character)
        {
            throw new InvalidOperationException("Cannot attack self!");
        }
        else if (this.Faction == character.Faction)
        {
            throw new ArgumentException($"Friendly fire! Both characters are from {Faction} faction!");
        }

        character.TakeDamage(AbilityPoints);


    }
}
