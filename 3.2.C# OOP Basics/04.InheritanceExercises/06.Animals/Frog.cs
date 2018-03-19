public class Frog
    : Animal
{
    public Frog(string input)
        : base(input)
    {

    }

    public override string ProduceSound()
    {
        return "Ribbit";
    }
}