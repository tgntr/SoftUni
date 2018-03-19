using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var connections = new List<string>();

        var people = new List<Person>();

        var key = Console.ReadLine();

        var input = "";
        while ((input = Console.ReadLine()) != "End")
        {
            if (input.Contains("-"))
            {

                connections.Add(input); 
            }
            else
            {
                people.Add(new Person(input));
            }
        }

        var keyPerson = GetPerson(key, people);

        foreach (var connection in connections)
        {
            var details = connection.Split("-").Select(x => x.Trim()).ToArray();
            var parent = GetPerson(details[0], people);
            var child = GetPerson(details[1], people);
            if (keyPerson.Name == parent.Name)
            {
                keyPerson.Children.Add(child);
            }
            else if (keyPerson.Name == child.Name)
            {
                keyPerson.Parents.Add(parent);
            }
        }

        keyPerson.PrintPerson();
    }

    

    public static Person GetPerson(string key, List<Person> people)
    {
        return people.Where(p => p.Birthday == key || p.Name == key).First();
    }
}
