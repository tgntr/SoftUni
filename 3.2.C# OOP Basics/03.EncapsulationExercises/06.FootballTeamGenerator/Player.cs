public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value == "")
                throw new System.Exception("A name should not be empty.");
            name = value;
        }
    }

    public int Endurance
    {
        get
        {
            return endurance;
        }
        set
        {
            if (ValidateStats(value))
                endurance = value;
            else
                throw new System.Exception("Endurance should be between 0 and 100.");

        }
    }

    public int Sprint
    {
        get
        {
            return sprint;
        }
        set
        {
            if (ValidateStats(value))
                sprint = value;
            else
                throw new System.Exception("Sprint should be between 0 and 100.");

        }
    }

    public int Dribble
    {
        get
        {
            return dribble;
        }
        set
        {
            if (ValidateStats(value))
                dribble = value;
            else
                throw new System.Exception("Dribble should be between 0 and 100.");

        }
    }

    public int Passing
    {
        get
        {
            return passing;
        }
        set
        {
            if (ValidateStats(value))
                passing = value;
            else
                throw new System.Exception("Passing should be between 0 and 100.");

        }
    }

    public int Shooting
    {
        get
        {
            return shooting;
        }
        set
        {
            if (ValidateStats(value))
                shooting = value;
            else
                throw new System.Exception("Shooting should be between 0 and 100.");

        }
    }

    public double SkillLevel => (Endurance + Sprint + Dribble + Passing + Shooting) / 5d;

    public Player (string input)
    {
        var details = input.Split(";");
        Name = details[2];
        Endurance = int.Parse(details[3]);
        Sprint = int.Parse(details[4]);
        Dribble = int.Parse(details[5]);
        Passing = int.Parse(details[6]);
        Shooting = int.Parse(details[7]);
    }

    public Player()
    {

    }

    public static bool ValidateStats(int stats)
    {
        return stats > 0 && stats <= 100;
    }
}
