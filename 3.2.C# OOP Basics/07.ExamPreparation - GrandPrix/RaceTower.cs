using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    private List<Driver> RegisteredDrivers = new List<Driver>();

    private Stack<Driver> FailedPlayers = new Stack<Driver>();

    private int currentLap = 0;

    private int TotalLaps { get; set; }

    private int TrackLength { get; set; }

    private string Weather = "Sunny";

    public bool IsOver => currentLap == TotalLaps;
    

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        TotalLaps = lapsNumber;

        TrackLength = trackLength;
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            RegisteredDrivers.Add(DriverFactory.CreateDriver(commandArgs));
        }
        catch
        {
        }
        
    }

    public void DriverBoxes(List<string> commandArgs)
    {


        var reasonToBox = commandArgs[0];

        var driver = RegisteredDrivers.FirstOrDefault(d=>d.Name == commandArgs[1]);

        driver.Box();


        if (reasonToBox == "Refuel")
        {
            var amount = double.Parse(commandArgs[2]);
            driver.Car.Refuel(amount);
        }
        else
        {
            driver.Car.ChangeTyre(TyreFactory.CreateTyre(commandArgs.Skip(2).ToArray()));
        }
        
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        var result = new StringBuilder();

        var laps = int.Parse(commandArgs[0]);
        try
        {
            if (currentLap + laps > TotalLaps)
            {
                throw new ArgumentException($"There is no time! On lap {currentLap}.");
            }
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

        for (int i = 0; i < laps; i++)
        {
            foreach (var driver in RegisteredDrivers.Where(d=>!d.Failed))
            {
                try
                {
                    driver.CompleteLap(TrackLength);
                }
                catch (ArgumentException ex)
                {
                    driver.Fail(ex.Message);
                    FailedPlayers.Push(driver);
                }
            }
            currentLap++;
            if (currentLap >= TotalLaps)
            {
                var winner = GetWinner();
                result.AppendLine($"{winner.Name} wins the race for {winner.TotalTime:F3} seconds.");
                return result.ToString().Trim();
            }
            Overtake(result);
        }

        return result.ToString().Trim();


    }

    private Driver GetWinner()
    {
        return RegisteredDrivers.Where(d => !d.Failed).OrderBy(d => d.TotalTime).FirstOrDefault();
    }

    private void Overtake(StringBuilder result)
    {
        var timetable = RegisteredDrivers.Where(d => !d.Failed).OrderByDescending(d => d.TotalTime).ToList();

        for (int y = 0; y < timetable.Count - 1; y++)
        {
            var overtakingDriver = timetable[y];
            var targetDriver = timetable[y + 1];
            var time =  overtakingDriver.TotalTime - targetDriver.TotalTime;
            
            var overtake = false;

            if (overtakingDriver is AggressiveDriver && overtakingDriver.Car.Tyre is UltrasoftTyre && time <= 3)
            {
                if (Weather == "Foggy")
                {
                    overtakingDriver.Fail("Crashed");
                    FailedPlayers.Push(overtakingDriver);
                }
                else
                {
                    overtake = true;
                    time = 3;
                }
            }
            else if (overtakingDriver is EnduranceDriver && overtakingDriver.Car.Tyre is HardTyre && time <= 3)
            {
                if (Weather == "Rainy")
                {
                    overtakingDriver.Fail("Crashed");
                    FailedPlayers.Push(overtakingDriver);

                }
                else
                {
                    overtake = true;
                    time = 3;
                }
            }
            else if (time <= 2)
            {
                overtake = true;
                time = 2;
            }

            if (overtake)
            {
                result.AppendLine($"{overtakingDriver.Name} has overtaken {targetDriver.Name} on lap {currentLap}.");
                y++;
                overtakingDriver.ReduceTime(time);
                targetDriver.IncreaseTime(time);
            }
        }
    }

    public string GetLeaderboard()
    {
        var leaderboard = new StringBuilder();
        leaderboard.AppendLine($"Lap {currentLap}/{TotalLaps}");
        var place = 1;
        foreach (var driver in RegisteredDrivers
            .Where(d=>!d.Failed)
            .OrderBy(d=>d.TotalTime))
        {
            leaderboard.AppendLine($"{place} {driver}");
            place++;
        }
        foreach (var driver in FailedPlayers.ToList())
        {
            leaderboard.AppendLine($"{place} {driver}");
            place++;
        }

        return leaderboard.ToString().Trim();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        Weather = commandArgs[0];
    }

}
