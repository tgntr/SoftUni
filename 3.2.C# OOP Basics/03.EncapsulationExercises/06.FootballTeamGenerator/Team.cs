using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;

    public string Name
    {
        get { return name;  }
        set
        {
            if (value == "")
                throw new System.Exception("A name should not be empty.");
            name = value;
        }
    }

    private List<Player> Players = new List<Player>();

    public double Rating
    {
        get
        {
            if (Players.Count > 0)
                return Players.Average(p => p.SkillLevel);
            else return 0;
        }
    }
    

    public Team(string name)
    {
        Name = name;
    }
    public static void AddPlayer (string input, Dictionary<string, Team> teams)
    {
        var team = input.Split(";")[1];
        try
        {
            teams[team].Players.Add(new Player(input));
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        
    }

    public static void RemovePlayer(string input, Dictionary<string, Team> teams)
    {
        var team = input.Split(";")[1];
        var name = input.Split(";")[2];
        if (!teams[team].Players.Any(p => p.Name == name))
            System.Console.WriteLine($"Player {name} is not in {team} team.");
        else
            teams[team].Players.RemoveAll(p => p.Name == name);
    }

    public override string ToString()
    {
        return $"{Name} - {Math.Round(Rating)}";
    }
}
