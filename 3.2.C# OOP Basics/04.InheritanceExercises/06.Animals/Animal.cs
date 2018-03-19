using System;

public abstract class Animal
    : ISoundProducable
{
    private int age;
    public string gender;
    public string Name { get; set; }

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Invalid input!");
            }

            age = value;
        }
    }

    public string Gender {
        get
        {
            return gender;
        }
        set
        {
            if (value != "Male" && value != "Female")
            {
                throw new System.ArgumentException("Invalid input!");
            }

            gender = value;
        }
    }

    public Animal(string input)
    {
        var details = input.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
        
        if (details.Length != 3)
        {
            throw new System.ArgumentException("Invalid input!");
        }

        Name = details[0];

        Age = int.Parse(details[1]);

        Gender = details[2];

    }

    public Animal()
    {

    }

    public abstract string ProduceSound();

    public override string ToString()
    {
        return $"{this.GetType().Name}\n{Name} {Age} {Gender}\n{ProduceSound()}";
    }

    public static Animal GetAnimal(string animal, string input)
    {
        switch (animal)
        {
            case "Dog":
                return new Dog(input);
            case "Frog":
                return new Frog(input);
            case "Cat":
                return new Cat(input);
            case "Kitten":
                return new Kitten(input);
            case "Tomcat":
                return new Tomcat(input);
            default:
                throw new ArgumentException("Invalid input!");
        }
    }

}