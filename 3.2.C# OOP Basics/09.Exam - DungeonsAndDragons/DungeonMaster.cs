using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DungeonMaster
{
    private List<Character> characters;
    private List<Item> items;
    private int survivorRounds = 0;
    private int CharactersAlive => characters.Where(c => c.IsAlive).Count();
    
    public DungeonMaster()
    {
        characters = new List<Character>();

        items = new List<Item>();
    }

    public string JoinParty(string[] args)
    {
        var faction = args[0];
        var character = args[1];
        var name = args[2];
        characters.Add(CharacterFactory.CreateCharacter(faction, character, name));
        return $"{name} joined the party!";
    }

    public string AddItemToPool(string[] args)
    {
        var itemName = args[0];
        items.Add(ItemFactory.CreateItem(itemName));
        return $"{itemName} added to pool.";
    }

    public string PickUpItem(string[] args)
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("No items left in pool!");
        }
        var charName = args[0];
        var character = GetCharacter(charName);
        var item = items.Last();
        character.Bag.AddItem(item);
        items.Remove(item);

        return $"{charName} picked up {item.GetType().Name}!";

    }
    

    public string UseItem(string[] args)
    {
        var character = GetCharacter(args[0]);
        var item = character.Bag.GetItem(args[1]);
        character.UseItem(item);

        return $"{character.Name} used {args[1]}.";
    }

    public string UseItemOn(string[] args)
    {
        var giver = GetCharacter(args[0]);
        var receiver = GetCharacter(args[1]);
        var item = giver.Bag.GetItem(args[2]);
        giver.UseItemOn(item, receiver);

        return $"{giver.Name} used {args[2]} on {receiver.Name}.";

    }

    public string GiveCharacterItem(string[] args)
    {
        var giverName = args[0];
        var receiverName = args[1];
        var itemName = args[2];

        var giver = GetCharacter(giverName);
        var receiver = GetCharacter(receiverName);

        giver.GiveCharacterItem(giver.Bag.GetItem(itemName), receiver);

        return $"{giverName} gave {receiverName} {itemName}.";
    }

    public string GetStats()
    {
        return string.Join(Environment.NewLine, characters.OrderByDescending(c => c.Status() == "Alive").ThenByDescending(c => c.Health));
    }

    public string Attack(string[] args)
    {
        var attackerName = args[0];
        var receiverName = args[1];

        var attacker = GetCharacter(attackerName);
        var receiver = GetCharacter(receiverName);
        if (attacker is Cleric)
        {
            throw new ArgumentException($"{args[0]} cannot attack!");
        }
        var warrior = (Warrior)attacker;
        warrior.Attack(receiver);

        var output = "";

        output += ($"{attacker.Name} attacks {receiver.Name} for {attacker.AbilityPoints} hit points! {receiver.Name} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");
        

        if (!receiver.IsAlive)
        {
            output += ($"{Environment.NewLine}{receiver.Name} is dead!");
        }
        return output;
    }

    public string Heal(string[] args)
    {
        var healerName = args[0];
        var receiverName = args[1];
        var healer = GetCharacter(healerName);
        var receiver = GetCharacter(receiverName);

        if (healer is Warrior)
        {
            throw new ArgumentException($"{args[0]} cannot heal!");
        }

        var cleric = (Cleric)healer;
        cleric.Heal(receiver);

        return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
    }

    public string EndTurn(string[] args)
    {
        
        var builder = new StringBuilder();
        foreach (var character in characters.Where(c=>c.IsAlive))
        {
            var currentHealth = character.Health;
            character.Rest();
            builder.AppendLine($"{character.Name} rests ({currentHealth} => {character.Health})");

        }
        if (CharactersAlive <= 1)
        {
            survivorRounds++;
        }
        return builder.ToString().Trim();
    }

    public bool IsGameOver()
    {
        return survivorRounds > 1 && CharactersAlive == 1;
    }
    

    private Character GetCharacter(string name)
    {
        if (!characters.Any(c=>c.Name == name))
        {
            throw new System.ArgumentException($"Character {name} not found!");
        }
        return characters.FirstOrDefault(c => c.Name == name);
    }
}