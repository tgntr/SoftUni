using System.Collections.Generic;

public class Car
{
    public string Model { get; set; }

    public Engine Engine { get; set; }

    public Cargo Cargo { get; set; }

    public List<Tyre> Tyres { get; set; }

    public Car(string input)
    {
        var carDetails = input.Split();

        Model = carDetails[0];

        var speed = int.Parse(carDetails[1]);
        var power = int.Parse(carDetails[2]);
        Engine = new Engine(speed, power);

        var weight = int.Parse(carDetails[3]);
        var type = carDetails[4];
        Cargo = new Cargo(weight, type);

        Tyres = new List<Tyre>();
        for (int i = 5; i < carDetails.Length-1; i+=2)
        {
            var pressure = double.Parse(carDetails[i]);
            var age = int.Parse(carDetails[i + 1]);
            var tyre = new Tyre(age, pressure);
            Tyres.Add(tyre);
        }
    }

    public override string ToString()
    {
        return $"{Model}";
    }
}
