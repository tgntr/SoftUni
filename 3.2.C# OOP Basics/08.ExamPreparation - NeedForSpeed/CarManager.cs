using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> openRaces;

    private Garage garage;

    public CarManager()
    {
        cars = new Dictionary<int, Car>();
        openRaces = new Dictionary<int, Race>();
        garage = new Garage();
    }
    


    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        cars.Add(id, CarFactory.CreateCar(type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
    }




    public string Check(int id)
    {
        return cars[id].ToString();
    }




    public void Open(int id, string type, int length, string route, int prizePool)
    {
        openRaces.Add(id, RaceFactory.CreateRace(type, length, route, prizePool));
    }

    public void Open(int id, string type, int length, string route, int prize, int param)
    {
        openRaces.Add(id, RaceFactory.CreateRace(type, length, route, prize, param));
    }



    public void Participate(int carId, int raceId)
    {
        if (!IsInGarage(carId))
        {
            if (!(openRaces[raceId] is TimeLimitRace && openRaces[raceId].Participants.Count == 1))
            {
                openRaces[raceId].Participants.Add(cars[carId]);

            }
        }
    }

    private bool IsInGarage(int id)
    {
        var car = cars[id];
        return garage.ParkedCars.Contains(car);
    }

    

    public string Start(int id)
    {
        if (openRaces[id].Participants.Count <= 0)
        {
            return "Cannot start the race with zero participants.";
        }
        var race = openRaces[id];
        if (race is CircuitRace)
        {
            var circuitRace = (CircuitRace)race;
            circuitRace.Start();
        }
        
        openRaces.Remove(id);
        return race.ToString();
    }
    

    public void Park(int id)
    {
        if (!IsInRace(id))
        {
            garage.ParkedCars.Add(cars[id]);
        }
    }

    private bool IsInRace(int id)
    {
        var car = cars[id];
        return openRaces.Values.Any(r=>r.Participants.Contains(car));
    }


    public void Unpark(int id)
    {
        var car = cars[id];
        garage.ParkedCars.Remove(car);
    }




    public void Tune(int tuneIndex, string addOn)
    {
        if (garage.ParkedCars.Count > 0)
        {
            foreach (var car in garage.ParkedCars)
            {
                car.Tune(tuneIndex, addOn);
            }
        }
    }



}

