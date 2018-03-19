using System;
using System.Collections.Generic;
using System.Text;

public class PerformanceCar
    : Car
{
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        Horsepower += (Horsepower * 50) / 100;

        Suspension -= (Suspension * 25) / 100;

        AddOns = new List<string>();
    }

    public List<string> AddOns { get; private set; }

    public override string ToString()
    {
        var addOns = "None";

        if (AddOns.Count > 0)
        {
            addOns = string.Join(", ", AddOns);
        }
        return base.ToString() + $"{Environment.NewLine}Add-ons: {addOns}";
    }

    internal override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        AddOns.Add(addOn);

    }
}
