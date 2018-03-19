public class Car
{
    public string Model { get; set; }

    public decimal FuelAvailable { get; set; }

    public decimal FuelPerKm { get; set; }

    public int Mileage { get; set; }


    public Car (string input)
    {
        var carDetails = input.Split();

        Model = carDetails[0];

        FuelAvailable = decimal.Parse(carDetails[1]);

        FuelPerKm = decimal.Parse(carDetails[2]);

        Mileage = 0;
    }

    public void Drive (int distance)
    {
        if (distance * FuelPerKm > FuelAvailable)
            System.Console.WriteLine("Insufficient fuel for the drive");
        else
        {
            FuelAvailable -= distance * FuelPerKm;
            Mileage += distance;
        }
    }

    public override string ToString()
    {
        return $"{Model} {FuelAvailable:F2} {Mileage}";
    }
}
