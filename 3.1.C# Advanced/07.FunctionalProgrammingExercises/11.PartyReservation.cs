using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservation
{
    class PartyReservation
    {
        static void Main()
        {
            var people = Console.ReadLine().Split().ToList();
            var filters = new List<string[]>();

            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                var command = input.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);


                if (command[0] == "Remove filter")
                {
                    Predicate<string[]> removeFilter = f => f[1] == command[1] && f[2] == command[2];
                    filters.RemoveAll(removeFilter);
                }
                else
                    filters.Add(command);
            }

            filters.ForEach(f => people.RemoveAll(CreatePredicate(f)));
            Console.WriteLine(string.Join(" ", people));
        }

        private static Predicate<string> CreatePredicate(string[] command)
        {
            var argument = command[1];
            if (argument == "Starts with")
            {
                var word = command[2];
                return name => name.StartsWith(word);
            }
            else if (argument == "Length")
            {
                var length = int.Parse(command[2]);
                return name => name.Length == length;
            }
            else if (argument == "Contains")
            {
                var word = command[2];
                return name => name.Contains(word);
            }
            else
            {
                var word = command[2];
                return name => name.EndsWith(word);
            }
        }
    }
}
