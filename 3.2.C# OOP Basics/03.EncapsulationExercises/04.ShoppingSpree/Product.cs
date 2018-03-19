public class Product
{
    public string Name { get; set; }

    public decimal Cost { get; set; }

    public Product(string input)
    {
        var details = input.Split("=");
        var name = details[0];
        var cost = decimal.Parse(details[1]);

        if (name.Trim() == "")
            throw new System.Exception("Name cannot be empty");
        else if (cost < 0)
            throw new System.Exception("Money cannot be negative");
        Name = name;
        Cost = cost;
    }

    public Product()
    {

    }

    public override string ToString()
    {
        return $"{Name}";
    }
}
