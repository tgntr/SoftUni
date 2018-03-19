public class Engine
{
    public string Model { get; set; }

    public int Power { get; set; }

    public string Displacement { get; set; }

    public string Efficiency { get; set; }

    public Engine()
    {
        Displacement = "n/a";

        Efficiency = "n/a";
    }

    public Engine(string input)
        : this()
    {
        var engineDetails = input.Split(new string[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);

        Model = engineDetails[0];

        Power = int.Parse(engineDetails[1]);

        var index = 2;
        var detailsCount = engineDetails.Length;
        while (index < detailsCount)
        {
            if (int.TryParse(engineDetails[index], out int displacement))
                Displacement = displacement.ToString();
            else
                Efficiency = engineDetails[index];
            index++;
        }
    }

    public override string ToString()
    {
        return $"  {Model}:\n    Power: {Power}\n    Displacement: {Displacement}\n    Efficiency: {Efficiency}";
    }
}
