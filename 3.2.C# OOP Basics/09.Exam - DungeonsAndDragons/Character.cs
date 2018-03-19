using System;
using System.Linq;

public abstract class Character
{
    private string name;
    private double health;
    private double armor;

    public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
    {
        Name = name;

        BaseHealth = health;
        Health = BaseHealth;


        BaseArmor = armor;

        Armor = BaseArmor;


        AbilityPoints = abilityPoints;

        Bag = bag;

        Faction = faction;

        RestHealMultiplier = 0.2;

        IsAlive = true;
    }

    internal void Repair()
    {
        Armor = BaseArmor;
    }



    internal void Heal(double weight)
    {
        Health += weight;
    }



    internal void Poison()
    {
        Health -= 20;

        if (Health <= 0)
        {
            IsAlive = false;
        }
    }




    public string Name
    {
        get
        {
            return name;
        }
        protected set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be null or whitespace!");
            }

            name = value;
        }
    }

    public double BaseHealth { get;  protected set; }

    public double Health
    {
        get
        {
            return health;
        }
        protected set
        {
            if (value < 0)
            {
                health = 0;
                IsAlive = false;
            }
            else if (value > BaseHealth)
            {
                health = BaseHealth;
            }
            else
            {
                health = value;
            }
        }
    }

    public double BaseArmor { get; protected set; }

    public double Armor
    {
        get
        {
            return armor;
        }
        protected set
        {
            if (value < 0)
            {
                armor = 0;
            }
            else
            {
                armor = value;
            }
        }
    }

    public double AbilityPoints { get; protected set; }

    public Bag Bag { get; protected set; }

    public Faction Faction { get; }

    public bool IsAlive { get; protected set; }
    

    public virtual double RestHealMultiplier { get; protected set; }

    public void TakeDamage(double hitPoints)
    {
        CheckIfAlive();
        var hitPointsLeft = hitPoints - Armor;
        Armor -= hitPoints;

        if (hitPointsLeft > 0)
        {
            Health -= hitPointsLeft;
        }
        if (Health <= 0)
        {
            IsAlive = false;
        }

    }

    private void CheckIfAlive()
    {
        if (!IsAlive)
        {
            throw new InvalidOperationException("Must be alive to perform this action!");
        }
    }

    public void Rest()
    {
        CheckIfAlive();
        Health += BaseHealth * RestHealMultiplier;
        
    }

    public void UseItem(Item item)
    {
        CheckIfAlive();
        BagIsEmpty();
        ItemIsAvailable(item.GetType().Name);
        item.AffectCharacter(this);


    }

    internal bool ItemIsAvailable(string name)
    {
        if (!Bag.Items.Any(i=> i.GetType().Name == name))
        {
            throw new ArgumentException($"No item with name {name} in bag!");
        }
        return true;
    }
    internal bool BagIsEmpty()
    {
        if (Bag.Items.Count == 0)
        {
            throw new InvalidOperationException("Bag is empty!");
        }
        return true;
    }

    public void UseItemOn(Item item, Character character)
    {
        CheckIfAlive();
        item.AffectCharacter(character);
    }

    public void GiveCharacterItem(Item item, Character character)
    {
        CheckIfAlive();
        character.CheckIfAlive();
        character.ReceiveItem(item);
    }

    public void ReceiveItem(Item item)
    {
        CheckIfAlive();
        Bag.AddItem(item);
        
    }

    public override string ToString()
    {
        return $"{Name} - HP: {Health}/{BaseHealth}, AP: {Armor}/{BaseArmor}, Status: {Status()}";   
    }

    internal string Status()
    {
        if (IsAlive)
            return "Alive";
        return "Dead";
    }
}