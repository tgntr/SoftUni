public class StreetExtraordinaireCat
    : Cat
{
    public int DecibelsOfMeow { get; set; }

    public StreetExtraordinaireCat(string input)
    {
        var details = input.Split();

        Type = details[0];

        Name = details[1];

        DecibelsOfMeow = int.Parse(details[2]);
    }

    public override string ToString()
    {
        return $"{Type} {Name} {DecibelsOfMeow}";
    }
}

