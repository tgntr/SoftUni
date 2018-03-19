public class Child:Person
{
    public Child(string name, int age):base(name, age)
    {
        if (age > 15)
            throw new System.Exception("Child's age must be less than 15!");
    }
}
