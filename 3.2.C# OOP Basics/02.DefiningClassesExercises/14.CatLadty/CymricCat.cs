public class CymricCat
    :Cat
{
    public double FurLength { get; set; }

    public CymricCat(string input)
    {
        var qwe = input.Split();

        Type = details[0];

        Name = details[1];

        FurLength = double.Parse(details[2]);
    }

    public override string ToString()
    {
        return $"{Type} {Name} {FurLength:F2}";
    }
}
