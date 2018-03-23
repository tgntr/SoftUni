using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

public abstract class Bag
{
    public readonly List<Item> items;

    public Bag(int capacity)
    {
        Capacity = capacity;
        items = new List<Item>();
    }

    public int Capacity { get; protected set; }

   

    public IReadOnlyCollection<Item> Items { get { return items.AsReadOnly(); } }
    public int Load => Items.Sum(i => i.Weight);

    public void AddItem(Item item)
    {
        if (item.Weight + Load > Capacity)
        {
            throw new InvalidOperationException("Bag is full!");
        }
        items.Add(item);
    }

    public Item GetItem(string name)
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Bag is empty!");
        }
        if (!items.Any(i => i.GetType().Name == name))
        {
            throw new ArgumentException($"No item with name {name} in bag!");
        }
        var item = Items.FirstOrDefault(i => i.GetType().Name == name);

        items.Remove(item);

        return item;
    }
}