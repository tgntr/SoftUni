public class Kitten
    : Cat
{
    public Kitten(string input)
        : base(input)
    {
        Gender = "Female";
    }

    public override string ProduceSound()
    {
        return "Meow";
    }
}