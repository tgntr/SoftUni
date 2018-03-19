public class Mood
{
    public int PointsOfHappines { get; private set; }

    public Mood(int points)
    {
        PointsOfHappines = points;
    }

    public override string ToString()
    {
        if (PointsOfHappines < -5)
            return "Angry";
        else if (PointsOfHappines < 1)
            return "Sad";
        else if (PointsOfHappines < 16)
            return "Happy";
        else
            return "JavaScript";
    }
}
