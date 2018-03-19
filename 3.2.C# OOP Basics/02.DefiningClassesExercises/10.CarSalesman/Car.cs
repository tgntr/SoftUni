using System.Collections.Generic;

public class Car
{
    public string Model { get; set; }

    public Engine Engine { get; set; }

    public string Weight { get; set; }

    public string Color { get; set; }

    public Car()
    {
        Weight = "n/a";

        Color = "n/a";
    }

    public Car(string input, Dictionary<string, Engine> engines)
        :this()
    {
        var carDetails = input.Split(new string[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);

        Model = carDetails[0];

        Engine = engines[carDetails[1]];

        var index = 2;
        var detailsCount = carDetails.Length;
        while (index < detailsCount)
        {
            if (int.TryParse(carDetails[index], out int weight))
                Weight = weight.ToString();
            else
                Color = carDetails[index];
            index++;
        }
    }

    public override string ToString()
    {
        return $"{Model}:\n{Engine}\n  Weight: {Weight}\n  Color: {Color}";
    }
}
