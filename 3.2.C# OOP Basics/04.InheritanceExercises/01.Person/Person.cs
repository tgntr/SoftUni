public class Person
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Trim().Length < 3)
                throw new System.Exception("Name's length should not be less than 3 symbols!");
            name = value;
        }
    }

    private int age;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
                throw new System.Exception("Age must be positive!");
            age = value;
        }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person()
    {

    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
