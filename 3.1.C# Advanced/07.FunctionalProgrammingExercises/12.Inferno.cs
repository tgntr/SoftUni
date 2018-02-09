using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Inferno
{
    class Inferno
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var exclusions = new List<string[]>();

            string input;
            while ((input = Console.ReadLine()) != "Forge")
            {
                var command = input.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);


                if (command[0] == "Reverse")
                {
                    Predicate<string[]> removeFilter = f => f[1] == command[1] && f[2] == command[2];
                    exclusions.RemoveAll(removeFilter);
                }
                else
                    exclusions.Add(command);
            }
            var toExclude = new List<int>();
            exclusions.ForEach(f => toExclude.AddRange(numbers.Where(CreatePredicate(f, numbers))));

            Console.WriteLine(string.Join(" ", numbers.Where(n=>!toExclude.Contains(n))));

        }

        private static Func<int, bool> CreatePredicate(string[] command, List<int> numbers)
        {
            var argument = command[1];
            var m = int.Parse(command[2]);
            if (argument == "Sum Left")
            {
                return n =>
                    {
                        var index = numbers.IndexOf(n);
                        if (index == 0)
                            return n == m;
                        else
                            return n + numbers[index - 1] == m;
                    };

            }
            else if (argument == "Sum Right")
            {
                return n =>
                {
                    var index = numbers.IndexOf(n);
                    if (index == numbers.Count -1)
                        return n == m;
                    else
                        return n + numbers[index + 1] == m;
                };
            }
            else
            {
                return n =>
                {
                    var index = numbers.IndexOf(n);
                    if (numbers.Count == 1)
                        return n == m;
                    else if (index == 0)
                        return n + numbers[index + 1] == m;
                    else if (index == numbers.Count - 1)
                        return n + numbers[index - 1] == m;
                    else
                        return n + numbers[index - 1] + numbers[index + 1] == m;
                };
            }
        }
    }
}
