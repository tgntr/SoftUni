using System.Collections.Generic;

public class Trainer
{
    public string Name { get; set; }

    public int Badges { get; set; }

    public List<Pokemon> Pokemons { get; set; }

    public Trainer()
    {
        Badges = 0;

        Pokemons = new List<Pokemon>();
    }

    public Trainer(string name)
        :this()
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name} {Badges} {Pokemons.Count}";
    }
}
