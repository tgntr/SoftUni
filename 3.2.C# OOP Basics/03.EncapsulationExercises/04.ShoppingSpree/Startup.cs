using System;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

        var people = new Dictionary<string, Person>();
        foreach (var p in input)
        {
            try
            {
                var person = new Person(p);
                people.Add(person.Name, person);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
        }

        input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

        var products = new Dictionary<string, Product>();
        foreach (var p in input)
        {
            try
            {
                var product = new Product(p);
                products.Add(product.Name, product);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
        }

        var command = "";
        while ((command = Console.ReadLine()) != "END")
        {
            var details = command.Split();

            var person = people[details[0]];

            var product = products[details[1]];

            person.Buy(product);
        }

        Console.WriteLine(string.Join("\n", people.Values));
    }
}
