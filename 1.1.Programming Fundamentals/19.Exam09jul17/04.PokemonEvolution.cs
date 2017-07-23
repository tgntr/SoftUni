using System;
using System.Collections.Generic;
using System.Linq;

class Evolution
{
    public string Type { get; set; }
    public long Index { get; set; }
}

class PokemonEvolution
{
    static void Main()
    {
        var pokemons = new Dictionary<string, List<Evolution>>();
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "wubbalubbadubdub")
            {
                break;
            }
            else if (input.Split().Length == 1)
            {
                if (pokemons.ContainsKey(input))
                {
                    Console.WriteLine($"# {input}");
                    foreach (var evolution in pokemons[input])
                    {
                        Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
                    }
                }
            }
            else
            {
                var pokemonName = input.Split('-')[0].Trim();
                var evolutionType = input.Split('>','-').Select(x=>x.Trim()).Where(x=>x!="").ToArray()[1];
                var evolutionindex = long.Parse(input.Split('>')[2].Trim());
                if (!pokemons.ContainsKey(pokemonName))
                {
                    pokemons[pokemonName] = new List<Evolution>();
                }
                pokemons[pokemonName].Add(new Evolution
                {
                    Type = evolutionType,
                    Index = evolutionindex
                });
            }
        }
        foreach (var pokemon in pokemons.Keys)
        {
            Console.WriteLine($"# {pokemon}");
            foreach (var evolution in pokemons[pokemon].OrderByDescending(x=>x.Index))
            {
                Console.WriteLine($"{evolution.Type} <-> {evolution.Index}");
            }
        }
    }
}
