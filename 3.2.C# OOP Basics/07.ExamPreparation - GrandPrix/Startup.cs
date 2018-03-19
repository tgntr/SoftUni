using System;
using System.Linq;

public class Startup
{
    static void Main(string[] args)
    {
        var laps = int.Parse(Console.ReadLine());

        var trackLength = int.Parse(Console.ReadLine());

        var race = new RaceTower();
        race.SetTrackInfo(laps, trackLength);

        while(!race.IsOver)
        {
            var input = Console.ReadLine().Split();

            var command = input[0];

            var details = input.Skip(1).ToList();

            if (command == "RegisterDriver")
            {
                race.RegisterDriver(details);
            }
            else if (command == "Leaderboard")
            {
                Console.WriteLine(race.GetLeaderboard());
            }
            else if(command == "CompleteLaps")
            {
                var output = race.CompleteLaps(details);
                if (output != "")
                {
                    Console.WriteLine(output);

                }
            }
            else if (command == "Box")
            {
                race.DriverBoxes(details);
            }
            else if (command == "ChangeWeather")
            {
                race.ChangeWeather(details);
            }


        }

    }
}
