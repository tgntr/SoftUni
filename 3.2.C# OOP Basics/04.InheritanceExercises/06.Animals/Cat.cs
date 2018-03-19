public class Cat
    : Animal
{
    public Cat(string input)
        : base(input)
    {

    }

    public Cat()
    {

    }

    public override string ProduceSound()
    {
        return "Meow meow";
    }
}
