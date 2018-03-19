public class Dog
    : Animal
{
    public Dog(string input)
        : base(input)
    {

    }

    public override string ProduceSound()
    {
        return "Woof!";
    }
}
