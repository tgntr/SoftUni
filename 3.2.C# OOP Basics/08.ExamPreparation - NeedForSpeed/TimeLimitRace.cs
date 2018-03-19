using System.Linq;
using System.Text;

public class TimeLimitRace
    : Race
{
    public TimeLimitRace(int length, string route, int prizePool, int goldTime)
        : base(length, route, prizePool)
    {
        GoldTime = goldTime;
    }

    public int GoldTime { get;private set; }

    public override string ToString()
    {
        var participant = Participants.First();

        var builder = new StringBuilder();

        builder.AppendLine($"{Route} - {Length}");

        builder.AppendLine($"{participant.Brand} {participant.Model} - {PerformancePoints(participant)} s.");

        builder.AppendLine($"{GetMedal()} Time, ${GetPrize(0)}.");

        return builder.ToString().Trim();
    }

    protected override int GetPrize(int i)
    {
        var timePerformance = PerformancePoints(Participants.First());

        if (timePerformance <= GoldTime)
        {
            return PrizePool;
        }
        else if (timePerformance <= GoldTime + 15)
        {
            return (PrizePool * 50) / 100;
        }
        else
        {
            return (PrizePool * 30) / 100;
        }
    }

    private string GetMedal()
    {
        var timePerformance = PerformancePoints(Participants.First());

        if (timePerformance <= GoldTime)
        {
            return "Gold";
        }
        else if (timePerformance <= GoldTime + 15)
        {
            return "Silver";
        }
        else
        {
            return "Bronze";
        }
    }
}
