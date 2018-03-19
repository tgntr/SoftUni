public class AggressiveDriver
    : Driver
{
    private const double CONSUMPTION = 2.7;

    public AggressiveDriver(string name, Car car)
        : base(name, car, CONSUMPTION)
    {
    }

    public override double Speed =>  base.Speed * 1.3;
}