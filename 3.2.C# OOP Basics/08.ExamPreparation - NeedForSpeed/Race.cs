using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    protected Race(int length, string route, int prizePool)
    {
        Length = length;

        Route = route;

        PrizePool = prizePool;

        Participants = new List<Car>();
    }

    public int Length { get; protected set; }

    public string Route { get; protected set; }

    public int PrizePool { get; protected set; }

    public List<Car> Participants { get; protected set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{Route} - {Length}");

        var winners = Participants.OrderByDescending(PerformancePoints).Take(3).ToList();

        for (int i = 0; i < winners.Count; i++)
        {
            var car = winners[i];
            GetPrize(i);
            builder.AppendLine($"{i + 1}. {car.Brand} {car.Model} {PerformancePoints(car)}PP - ${GetPrize(i)}");
        }

        return builder.ToString().Trim();

    }

    protected virtual int GetPrize(int i)
    {
        var prize = 0;
        switch (i)
        {
            case 0:
                prize = (PrizePool * 50)/100;
                break;
            case 1:
                prize = (PrizePool * 30) / 100;
                break;
            default:
                prize = (PrizePool * 20) / 100; ;
                break;
        }
        return prize;
    }

    protected double PerformancePoints(Car car)
    {
        var raceType = this.GetType().Name;
        if (raceType == "CasualRace" || raceType == "CircuitRace")
        {
            return (car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability);
        }
        else if (raceType == "DragRace")
        {
            return car.Horsepower / car.Acceleration;
        }
        else if (raceType == "TimeLimitRace" )
        {
            return Length * ((car.Horsepower / 100) * car.Acceleration);
        }
        return car.Suspension + car.Durability;
    }
}
