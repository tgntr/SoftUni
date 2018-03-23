using System;

public class Cleric
    : Character, IHealable
{
    public Cleric(string name, Faction faction)
        : base(name, 50, 25, 40, BagFactory.CreateBag("Backpack"), faction)
    {
        RestHealMultiplier = 0.5;
    }

    public void Heal(Character character)
    {
        CheckIfAlive();
        character.CheckIfAlive();
        if (Faction != character.Faction)
        {
            throw new InvalidOperationException("Cannot heal enemy character!");
        }
        character.Heal(AbilityPoints);
    }
}