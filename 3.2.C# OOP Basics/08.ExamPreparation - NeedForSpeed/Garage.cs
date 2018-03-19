using System.Collections.Generic;

public class Garage
{
    public List<Car> ParkedCars { get; private set; }

    public Garage()
    {
        ParkedCars = new List<Car>();
    }
}
