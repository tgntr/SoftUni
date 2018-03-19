public class SiameseCat
    :Cat
{
    public int EarSize { get; set; }

    public SiameseCat(string input)
    {
        var details = input.Split();

        Type = details[0];

        Name = details[1];

        EarSize = int.Parse(details[2]);
    }

    public override string ToString()
    {
        return $"{Type} {Name} {EarSize}";
    }
}
