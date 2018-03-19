public class Ferrari
    :ICar 
{
    public string Model => "488-Spider";

    public string Driver { get; set; }

    public Ferrari(string driver)
    {
        Driver = driver;
    }

    public string Brake()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{Model}/{Brake()}/{Gas()}/{Driver}";
    }
}