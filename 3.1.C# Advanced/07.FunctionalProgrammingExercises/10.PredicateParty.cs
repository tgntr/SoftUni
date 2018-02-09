using System;
using System.Linq;

namespace _10.PredicateParty
{
    class PredicateParty
    {
        static void Main()
        {
            var people = Console.ReadLine().Split().ToList();

            string input;

            while ((input = Console.ReadLine()) != "Party!")
            {
                var command = input.Split();
                var operation = command[0];
                var argument = command[1];

                Predicate<string> meetRequirements = CreatePredicate(command);

                if (operation == "Remove")
                    people.RemoveAll(meetRequirements);
                else
                {
                    foreach (var person in people.FindAll(meetRequirements))
                    {
                        var index = people.IndexOf(person);
                        people.Insert(index, person);
                    }
                }
            }

            if (people.Count == 0)
                Console.WriteLine("Nobody is going to the party!");
            else
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
        }

        private static Predicate<string> CreatePredicate(string[] command)
        {
            var argument = command[1];
            if (argument == "StartsWith")
            {
                var word = command[2];
                return name => name.StartsWith(word);
            }
            else if (argument == "Length")
            {
                var length = int.Parse(command[2]);
                return name => name.Length == length;
            }
            else
            {
                var word = command[2];
                return name => name.EndsWith(word);
            }
        }
    }
}
