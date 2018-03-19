public abstract class Driver
{

    protected Driver(string name, Car car, double fuelConsumptionPerKm)
    {
        Name = name;
        Car = car;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
        TotalTime = 0d;
        Failure = "";
        Failed = false;
    }




    public string Name { get; }

    public double TotalTime { get; private set; }

    public Car Car { get;}

    public double FuelConsumptionPerKm { get; }

    public virtual double Speed => (Car.Hp + Car.Tyre.Degradation) / Car.FuelAmount;

    internal string Failure { get; private set; }
    
    internal bool Failed { get; private set; }

    internal  void CompleteLap (int trackLength)
    {
        TotalTime += 60 / (trackLength / Speed);
        Car.ReduceFuel(trackLength * FuelConsumptionPerKm);
        Car.Tyre.Degradate();
    }

    internal void Box()
    {
        TotalTime += 20;
    }
    
    internal void Fail(string message)
    {
        Failure = message;
        Failed = true;
    }
    private string Status()
    {
        if (!Failed)
        {
            return TotalTime.ToString("F3");
        }
        return Failure;
    }

    internal void ReduceTime(double time)
    {
        TotalTime -= time;
    }

    internal void IncreaseTime(double time)
    {
        TotalTime += time;
    }

    public override string ToString()
    {
        return $"{Name} {Status()}";
    }
}
