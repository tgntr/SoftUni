using System;

class Journey
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();
        double expenses = 0;
        string type = "";
        string destination = "";

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "winter")
            {
                expenses = budget * (70d / 100d);
                type = "Hotel";
            }
            else
            {
                expenses = budget * (30d / 100d);
                type = "Camp";
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "winter")
            {
                expenses = budget * (80d / 100d);
                type = "Hotel";
            }
            else
            {
                expenses = budget * (40d / 100d);
                type = "Camp";
            }
        }
        else
        {
            destination = "Europe";
            expenses = budget * (90d / 100d);
            type = "Hotel";

        }
        Console.WriteLine("Somewhere in {0}\n{1} - {2:F2}", destination, type, expenses);
        Console.ReadLine();
    }
}