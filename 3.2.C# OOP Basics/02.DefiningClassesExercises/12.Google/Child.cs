public class Child
{
    public string Name { get; set; }

    public string Birthday { get; set; }

    public Child()
    {
        Name = "";

        Birthday = "";
    }

    public Child(string name, string birthday)
    {
        Name = name;

        Birthday = birthday;
    }

    public override string ToString()
    {
        if (Name == "")
            return "";
        return $"\n{Name} {Birthday}";
    }
}

