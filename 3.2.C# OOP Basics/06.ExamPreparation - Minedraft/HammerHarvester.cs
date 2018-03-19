public class HammerHarvester
    : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        :base (id, oreOutput, energyRequirement)
    {
        OreOutput += OreOutput * 2;

        EnergyRequirement *= 2;
        
    }

    public override string ToString()
    {
        return "Hammer " + base.ToString();
    }
}