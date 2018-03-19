using System;

class Startup
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var family = new Family();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            family.AddMember(new Person(name, age));
        }

        Console.WriteLine(family.GetOldestMember());
    }
}
