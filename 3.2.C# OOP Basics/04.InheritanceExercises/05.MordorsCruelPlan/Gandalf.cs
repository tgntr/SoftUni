using System.Collections.Generic;
using System.Linq;

public class Gandalf
{
    public List<Food> Foods { get; private set; }

    public int PointsOfHappiness => Foods.Sum(f => f.Points);

    public Mood Mood => new Mood(PointsOfHappiness);

    public Gandalf(string input)
    {
        Foods = input.Split().Select(Food.GetFood).ToList();
    }

    public override string ToString()
    {
        return $"{PointsOfHappiness}\n{Mood}";
    }
}
