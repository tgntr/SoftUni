using System;

public class CharacterFactory
{
    
    public  Character CreateCharacter(string[] details)
    {
        var faction = FactionFactory.CreateFaction(details[0]);

        var characterType = details[1];

        var name = details[2];

        if (characterType == "Warrior")
        {
            return new Warrior(name, faction);
        }
        else if (characterType == "Cleric")
        {
            return new Cleric(name, faction);
        }
        throw new ArgumentException($"Invalid character type \"{characterType}\"!");
    }
}
