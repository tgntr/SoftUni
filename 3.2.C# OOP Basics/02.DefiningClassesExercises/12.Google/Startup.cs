using System;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var people = new Dictionary<string, Person>();

        var input = "";
        while ((input = Console.ReadLine()) != "End")
        {
            var details = input.Split();

            var name = details[0];

            if (!people.ContainsKey(name))
            {
                people[name] = new Person(name);
            }

            var infoType = details[1];

            if (infoType == "company")
            {
                var company = details[2];

                var department = details[3];

                var salary = decimal.Parse(details[4]);

                people[name].JobInfo = new Job(company, department, salary);
            }
            else if (infoType == "car")
            {
                var model = details[2];

                var speed = details[3];

                people[name].Car = new Car(model, speed);
            }
            else if (infoType == "parents")
            {
                var parent = details[2];

                var birthday = details[3];

                people[name].Parents.Add(new Parent(parent, birthday));
            }
            else if (infoType == "children")
            {
                var child = details[2];

                var birthday = details[3];

                people[name].Children.Add(new Child(child, birthday));
            }
            else if (infoType == "pokemon")
            {
                var pokemon = details[2];

                var type = details[3];

                people[name].Pokemons.Add(new Pokemon(pokemon, type));
            }
        }

        var person = Console.ReadLine();

        Console.WriteLine(people[person]);
    }
}