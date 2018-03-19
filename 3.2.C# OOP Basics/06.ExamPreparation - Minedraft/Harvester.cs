using System;
using System.Text;

public abstract class Harvester
    :Identify
{
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
        :base(id)
    {
        OreOutput = oreOutput;

        EnergyRequirement = energyRequirement;
    }
    

    public double OreOutput {
        get
        {
            return oreOutput;
        }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get
        {
            return energyRequirement;
        }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Harvested - {Id}");
        builder.AppendLine($"Ore Output: {OreOutput}");
        builder.AppendLine($"Energy Requirement: {EnergyRequirement}");
        return builder.ToString().TrimEnd();
    }
}
