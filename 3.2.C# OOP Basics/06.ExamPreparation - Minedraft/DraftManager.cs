using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;

    private List<Provider> providers;

    private List<Harvester> harvesters;

    public DraftManager()
    {
        mode = "Full";
        totalMinedOre = 0;
        totalStoredEnergy = 0;
        providers = new List<Provider>();
        harvesters = new List<Harvester>();
    }

    private double RequiredEnergy
    {
        get
        {
            var multiplier = 1d;
            if (mode == "Half")
            {
                multiplier = 0.6;
            }
            else if (mode == "Energy")
            {
                return 0;
            }

            return harvesters.Sum(h => h.EnergyRequirement) * multiplier ;
        }
    }

    private double ProvideOre
    {
        get
        {
            var multiplier = 1d;
            if (mode == "Half")
            {
                multiplier = 0.5;
            }
            else if (mode == "Energy")
            {
                return 0;
            }

            return harvesters.Sum(h => h.OreOutput) * multiplier;
        }
    }

    private double ProvideEnergy
    {
        get
        {
            return providers.Sum(p => p.EnergyOutput);
        }
    }

    public string RegisterHarvester(List<string> arguments)
    {

        var type = arguments[0];
        var id = arguments[1];
        try
        {
            var harvester = HarvesterFactory.CreateHarvester(arguments);

            harvesters.Add(harvester);
            
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
        return $"Successfully registered {type} Harvester - {id}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        try
        {
            var provider = ProviderFactory.CreateProvider(arguments);
            providers.Add(provider);
            
            
        }
        catch (ArgumentException ex)
        {
            return ex.Message;   
        }
        return $"Successfully registered {type} Provider - {id}";
    }
    public string Day()
    {
        totalStoredEnergy += ProvideEnergy;
        if (totalStoredEnergy >= RequiredEnergy)
        {
            totalMinedOre += ProvideOre;
            totalStoredEnergy -= RequiredEnergy;
        }
        var builder = new StringBuilder();
        builder.AppendLine("A day has passed.");
        builder.AppendLine($"Energy Provided: {ProvideEnergy}");
        builder.AppendLine($"Plumbus Ore Mined: {ProvideOre}");

        return builder.ToString().TrimEnd();


    }
    public string Mode(List<string> arguments)
    {
        mode = arguments[0];

        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        if (harvesters.Any(h => h.Id == id))
        {
            return harvesters.FirstOrDefault(h => h.Id == id).ToString();
        }
        else if (providers.Any(p => p.Id == id))
        {
            return providers.FirstOrDefault(p=> p.Id == id).ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }
    public string ShutDown()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"System Shutdown");
        builder.AppendLine($"Total Energy Stored: {totalStoredEnergy}");
        builder.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

        return builder.ToString().TrimEnd();
    }

}
