using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main(string[] args)
    {
        var people = new List<Person>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            people.Add(new Person(name, age));
        }

        Console.WriteLine(string.Join("\n", people.Where(p=>p.Age > 30).OrderBy(p=>p.Name)));
    }
}
