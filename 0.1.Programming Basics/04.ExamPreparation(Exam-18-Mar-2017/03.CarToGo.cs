using System;

class CarToGo
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string car = "";
        string type = "";
        double cost = 0;
        if (budget <= 100)
        {
            type = "Economy class";
            if (season == "Summer")
            {
                car = "Cabrio";
                cost = budget * 0.35;
            }
            else
            {
                car = "Jeep";
                cost = budget * 0.65;
            }
        }
        else if (budget <= 500)
        {
            type = "Compact class";
            if (season == "Summer")
            {
                car = "Cabrio";
                cost = budget * 0.45;
            }
            else
            {
                car = "Jeep";
                cost = budget * 0.80;
            }
        }
        else
        {
            type = "Luxury class";
            cost = 0.9 * budget;
            car = "Jeep";
        }
        Console.WriteLine("{0} \n{1} - {2:F2}", type, car, cost);
    }
}

