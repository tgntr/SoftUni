using System;

public class ItemFactory
{
    public  static Item CreateItem(string name)
    {
        if (name == "HealthPotion")
        {
            return new HealthPotion();
        }
        else if (name == "PoisonPotion")
        {
            return new PoisonPotion();
        }
        else if (name == "ArmorRepairKit")
        {
            return new ArmorRepairKit();
        }
        throw new ArgumentException($"Invalid item \"{name}\"!");
    }
}