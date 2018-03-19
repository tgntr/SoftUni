public class SonicHarvester
    : Harvester
{
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement)
    {
        SonicFactor = sonicFactor;
        EnergyRequirement /= SonicFactor;
    }
    private int SonicFactor { get;  }

    public override string ToString()
    {
        return "Sonic " + base.ToString();
    }
}
