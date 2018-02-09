using System;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main()
        {
            var bounds = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var lowerBound = bounds[0];
            var upperBound = bounds[1];
            var command = Console.ReadLine();
            var meetRequirement = CreatePredicate(command);
            var numbers = Enumerable.Range(lowerBound, upperBound - lowerBound + 1)
                .ToList()
                .FindAll(meetRequirement);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static Predicate<int> CreatePredicate (string command)
        {
            if (command == "odd")
                return n => n % 2 != 0;
            else
                return n => n % 2 == 0;
        }
    }
}
