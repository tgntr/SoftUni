using System;
using System.Linq;
using System.Text;

public class CircuitRace
    :Race
{
    public CircuitRace(int length, string route, int prizePool, int laps)
        : base(length, route, prizePool)
    {
        Laps = laps;
    }

    public int Laps { get;private set; }

    internal void Start()
    {
        Participants.ForEach(p => p.DecreaseDurability(Laps * (Length * Length)));
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"{Route} - {Length * Laps}");

        var winners = Participants.OrderByDescending(PerformancePoints).Take(4).ToList();

        for (int i = 0; i < winners.Count; i++)
        {
            var car = winners[i];
            GetPrize(i);
            builder.AppendLine($"{i + 1}. {car.Brand} {car.Model} {PerformancePoints(car)}PP - ${GetPrize(i)}");
        }

        return builder.ToString().Trim();
    }

    protected override int GetPrize(int i)
    {
        var prize = 0;
        switch (i)
        {
            case 0:
                prize = (PrizePool * 40) / 100;
                break;
            case 1:
                prize = (PrizePool * 30) / 100;
                break;
            case 2:
                prize = (PrizePool * 20) / 100;
                break;
            default:
                prize = (PrizePool * 10) / 100; 
                break;
        }
        return prize;
    }
}
