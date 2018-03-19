using System;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var engines = new Dictionary<string, Engine>();

        for (int i = 0; i < n; i++)
        {
            var engine = new Engine(Console.ReadLine());
            engines.Add(engine.Model, engine);
        }

        var m = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int i = 0; i < m; i++)
        {
            var car = new Car(Console.ReadLine(), engines);
            cars.Add(car);
        }

        Console.WriteLine(string.Join("\n", cars));
    }
}
