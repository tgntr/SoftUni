using System.Collections.Generic;
using System.Linq;

public class DriverFactory
{
    public static Driver CreateDriver(List<string> commandArgs)
    {
        var name = commandArgs[1];

        var carHp = int.Parse(commandArgs[2]);
        var carFuelAmount = double.Parse(commandArgs[3]);

        var tyre = TyreFactory.CreateTyre(commandArgs.Skip(4).ToArray());

        var car = new Car(carHp, carFuelAmount, tyre);

        var type = commandArgs[0];

        if (type == "Aggressive")
        {
            return new AggressiveDriver(name, car);
        }
        else
        {
            return new EnduranceDriver(name, car);
        }
    }
}
