using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;

    private Dough dough;

    private List<Topping> toppings;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length < 1 || value.Length > 15)
                throw new System.Exception("Pizza name should be between 1 and 15 symbols.");
            name = value;
        }
    }

    public Dough Dough { get; set; }

    public List<Topping> Toppings
    {
        get
        {
            return toppings;
        }
        set
        {
            if (value.Count > 10)
                throw new System.Exception("Number of toppings should be in range [0..10].");
            toppings = value;
        }
    }

    public double Calories => Dough.Calories + Toppings.Sum(t => t.Calories);

    public Pizza()
    {

    }

    public override string ToString()
    {
        return $"{Name} - {Calories:F2} Calories.";
    }
    
}