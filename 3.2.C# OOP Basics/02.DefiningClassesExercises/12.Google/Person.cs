using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }

    public Job JobInfo { get; set; }

    public Car Car { get; set; }

    public List<Parent> Parents { get; set; }

    public List<Child> Children { get; set; }

    public List<Pokemon> Pokemons { get; set; }

    public Person()
    {
        JobInfo = new Job();

        Car = new Car();

        Parents = new List<Parent>();

        Children = new List<Child>();

        Pokemons = new List<Pokemon>();
    }

    public Person(string name)
        :this()
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name}\nCompany:{JobInfo}\nCar:{Car}\nPokemon:{string.Join("", Pokemons)}\nParents:{string.Join("", Parents)}\nChildren:{string.Join("", Children)}";
    }
}
