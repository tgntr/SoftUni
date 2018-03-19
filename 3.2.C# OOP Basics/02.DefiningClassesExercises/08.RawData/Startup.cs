using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            cars.Add(new Car(Console.ReadLine()));
        }
        var command = Console.ReadLine();
        if (command == "fragile")
        {
            Console.WriteLine(string.Join("\n", cars.Where(c=>c.Cargo.Type == "fragile" && c.Tyres.Any(t=>t.Pressure < 1))));
        }
        else
        {
            Console.WriteLine(string.Join("\n", cars.Where(c=>c.Cargo.Type == "flamable" && c.Engine.Power > 250)));
        }
    }
}
