using System;
using System.Reflection;
using System.Text;

public abstract class Provider
    :Identify

{
    private double energyOutput;

    protected Provider(string id, double energyOutput)
        :base (id)
    {
        EnergyOutput = energyOutput;
    }
    

    public double EnergyOutput
    {
        get
        {
            return energyOutput;
        }
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            }
            energyOutput = value;
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"Provider - {Id}");
        builder.AppendLine($"Energy output: {EnergyOutput}");

        return builder.ToString().TrimEnd();
    }

}
