using System;

public class Car
{
    private const double FUEL_CAPACITY = 160;

    private double fuelAmount;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        Hp = hp;
        FuelAmount = fuelAmount;
        Tyre = tyre;
    }

    public int Hp { get; }

    public double FuelAmount
    {
        get
        {
            return fuelAmount;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Out of fuel");
            }
            fuelAmount = Math.Min(value, FUEL_CAPACITY);
        }
    }

    public Tyre Tyre { get; private set; }

    internal void ReduceFuel(double amount)
    {
        FuelAmount -= amount;
    }

    internal void Refuel (double amount)
    {
        FuelAmount += amount;
    }

    internal void ChangeTyre(Tyre tyre)
    {
        Tyre = tyre;
    }
    
}