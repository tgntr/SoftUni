using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }

    public decimal Money { get; set; }

    public List<Product> Bag { get; set; }

    public Person(string input)
    {
        var details = input.Split("=");
        var name = details[0];
        var money = decimal.Parse(details[1]);

        if (name.Trim() == "")
            throw new System.Exception("Name cannot be empty");
        else if(money < 0)
            throw new System.Exception("Money cannot be negative");

        Name = name;

        Money = money;

        Bag = new List<Product>();
    }

    public void Buy(Product product)
    {
        if (product.Cost > Money)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
        else
        {
            Bag.Add(product);
            Money -= product.Cost;
            Console.WriteLine($"{Name} bought {product.Name}");
        }
    }

    public override string ToString()
    {
        if (Bag.Count == 0)
            return $"{Name} - Nothing bought";
        else
        {
            return $"{Name} - {string.Join(", ", Bag)}";
        }
    }
}
