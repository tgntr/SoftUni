using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var trainers = new Dictionary<string, Trainer>();

        var input = "";
        while ((input = Console.ReadLine()) != "Tournament")
        {
            var details = input.Split();

            var trainer = details[0];

            if (!trainers.ContainsKey(trainer))
            {
                trainers.Add(trainer, new Trainer(trainer));
            }

            var pokemonName = details[1];

            var element = details[2];

            var health = int.Parse(details[3]);

            var pokemon = new Pokemon(pokemonName, element, health);

            trainers[trainer].Pokemons.Add(pokemon);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers.Values)
            {
                if (trainer.Pokemons.Any(p=>p.Element == input))
                {
                    trainer.Badges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(p => p.Health -= 10);
                    trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                }
            }
        }

        Console.WriteLine(string.Join("\n", trainers.Values.OrderByDescending(t=>t.Badges)));
    }
}
