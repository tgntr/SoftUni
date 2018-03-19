using System;
using System.Text;

public class ShowCar
    : Car
{
    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
    }

    public int Stars { get; private set; }

    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}{Stars} *";
    }

    internal override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        Stars += tuneIndex;
    }
}