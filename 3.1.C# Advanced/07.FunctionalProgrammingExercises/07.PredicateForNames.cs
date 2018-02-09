using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class PredicateForNames
    {
        static void Main()
        {
            var allowedLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Predicate<string> meetRequiredLength = name => name.Length <= allowedLength;
            Action<string> print = name => Console.WriteLine(name);
            names
                .FindAll(meetRequiredLength)
                .ForEach(print);
        }
    }
}
