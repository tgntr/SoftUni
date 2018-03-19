public class PressureProvider
    : Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        EnergyOutput += EnergyOutput / 2d;
    }

    public override string ToString()
    {
        return "Pressure " + base.ToString();
    }
}
