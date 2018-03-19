public class Tomcat
    : Cat
{
    public Tomcat(string input)
        : base(input)
    {
        Gender = "Male";
    }

    public override string ProduceSound()
    {
        return "MEOW";
    }
}