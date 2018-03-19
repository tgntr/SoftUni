using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester CreateHarvester (List<string> details)
    {
        var type = details[0];

        var id = details[1];

        var oreOutput = double.Parse(details[2]);

        var energyRequirement = double.Parse(details[3]);
        if (type == "Sonic")
        {
            var sonicFactor = int.Parse(details[4]);
            return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }
        return new HammerHarvester(id, oreOutput, energyRequirement);
    }
}