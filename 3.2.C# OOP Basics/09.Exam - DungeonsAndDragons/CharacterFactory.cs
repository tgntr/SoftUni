using System;

public class CharacterFactory
{
    
    public static Character CreateCharacter(string factionType, string characterType, string characterName)
    {
        var faction = FactionFactory.CreateFaction(factionType);

        var character = characterType;

        var name = characterName;

        if (characterType == "Warrior")
        {
            return new Warrior(name, faction);
        }
        else if (characterType == "Cleric")
        {
            return new Cleric(name, faction);
        }
        throw new ArgumentException($"Invalid character \"{characterType}\"!");
    }
}
