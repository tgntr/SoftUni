using System;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var teams = new Dictionary<string, Team>();

        var input = "";

        while ((input = Console.ReadLine())!="END")
        {
            var command = input.Split(";")[0];
            var team = input.Split(";")[1];

            if (command == "Team")
            {
                try
                {
                    teams.Add(team, new Team(team));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (!teams.ContainsKey(team))
                System.Console.WriteLine($"Team {team} does not exist.");
            else if (command == "Add")
            {
                Team.AddPlayer(input, teams);
            }
            else if (command == "Remove")
            {
                Team.RemovePlayer(input, teams);
            }
            else
            {
                Console.WriteLine(teams[team]);
            }
        }
    }
}
