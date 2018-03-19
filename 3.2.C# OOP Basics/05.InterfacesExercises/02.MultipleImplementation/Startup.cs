using System;

class Startup
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var id = Console.ReadLine();
        var birthdate = Console.ReadLine();
        var identifiable = new Citizen(name, age, id, birthdate);
        var birthable = new Citizen(name, age, id, birthdate);
        Console.WriteLine(identifiable.Id);
        Console.WriteLine(birthable.Birthdate);

    }
}
