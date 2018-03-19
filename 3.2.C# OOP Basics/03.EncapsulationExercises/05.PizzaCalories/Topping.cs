using System.Collections.Generic;

public class Topping
{
    public KeyValuePair<string, double> Type { get; set; }

    public double Weight { get; set; }

    public double Calories => (Weight * 2) * Type.Value;

    public Topping (string input)
    {
        var details = input.Split();

        var toppings = new Dictionary<string, double>();
        toppings.Add("meat", 1.2);
        toppings.Add("veggies", 0.8);
        toppings.Add("cheese", 1.1);
        toppings.Add("sauce", 0.9);

        var type = details[1];
        if (!toppings.ContainsKey(type.ToLower()))
        {
            throw new System.Exception($"Cannot place {type} on top of your pizza.");
        }
        Type = new KeyValuePair<string, double>(type, toppings[type.ToLower()]);

        var weight = double.Parse(details[2]);
        if (weight < 1 || weight > 50)
            throw new System.Exception($"{type} weight should be in the range [1..50].");
        Weight = weight;
    }

    public Topping()
    {

    }
}

