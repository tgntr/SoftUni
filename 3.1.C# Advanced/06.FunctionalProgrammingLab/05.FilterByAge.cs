using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class FilterByAge
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                var person = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var name = person[0];
                var agee = int.Parse(person[1]);
                people[name] = agee;
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            var personMeetsAgeRequirements = CreateAgeFilterFunc(age, condition);
            var print = CreatePrintAction(format);
            people
                .Where(personMeetsAgeRequirements)
                .ToList()
                .ForEach(print);
        }

        static Func<KeyValuePair<string,int>, bool> CreateAgeFilterFunc
            (int age, string condition)
        {
            if (condition == "older")
                return p => p.Value >= age;
            else
                return p => p.Value < age;
        }

        static Action<KeyValuePair<string, int>> CreatePrintAction
            (string filter)
        {
            if (filter == "name")
                return p => Console.WriteLine(p.Key);
            else if (filter == "age")
                return p => Console.WriteLine(p.Value);
            else
                return p => Console.WriteLine($"{p.Key} - {p.Value}");
        }
    }
}
