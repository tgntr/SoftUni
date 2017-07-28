using System;

class Vacation
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string location = "";
        string type = "";
        double cost = 0;
        if (budget <= 1000)
        {
            type = "Camp";
            if (season == "Summer")
            {
                location = "Alaska";
                cost = budget * 0.65;
            }
            else
            {
                location = "Morocco";
                cost = budget * 0.45;
            }
        }
        else if (budget <= 3000)
        {
            type = "Hut";
            if (season == "Summer")
            {
                location = "Alaska";
                cost = budget * 0.80;
            }
            else
            {
                location = "Morocco";
                cost = budget * 0.60;
            }
        }
        else
        {
            type = "Hotel";
            cost = 0.9 * budget;
            if (season == "Summer")
            {
                location = "Alaska";
            }
            else
            {
                location = "Morocco";
            }
        }
        Console.WriteLine("{0} - {1} - {2:F2}", location, type, cost);
    }
}
