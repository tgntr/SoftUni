using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider CreateProvider(List<string> details)
    {
        var type = details[0];

        var id = details[1];

        var energyOutput = double.Parse(details[2]);
        
        if (type == "Solar")
        {
            return new SolarProvider(id, energyOutput);
        }
        return new PressureProvider(id, energyOutput);
    }
}
