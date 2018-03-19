public class Pokemon
{
    public string Name { get; set; }

    public string Type { get; set; }

    public Pokemon()
    {
        Name = "";

        Type = "";
    }

    public Pokemon(string name, string type)
    {
        Name = name;

        Type = type;
    }

    public override string ToString()
    {
        if (Name == "")
            return "";
        return $"\n{Name} {Type}";
    }
}

