public class Car
{
    public string Model { get; set; }

    public string Speed { get; set; }

    public Car()
    {
        Model = "";

        Speed = "";
    }

    public Car(string model, string speed)
    {
        Model = model;

        Speed = speed;
    }

    public override string ToString()
    {
        if (Model == "")
            return "";
        return $"\n{Model} {Speed}";
    }
}
