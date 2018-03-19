using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var cars = new Dictionary<string, Car>();
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var car = new Car(Console.ReadLine());
            cars.Add(car.Model, car);
        }
        
        var input = "";

        while ((input = Console.ReadLine()) != "End")
        {
            var driveDetails = input.Split();
            var car = driveDetails[1];
            var distance = int.Parse(driveDetails[2]);

            cars[car].Drive(distance);
        }

        Console.WriteLine(string.Join("\n", cars.Values));
    }
}
