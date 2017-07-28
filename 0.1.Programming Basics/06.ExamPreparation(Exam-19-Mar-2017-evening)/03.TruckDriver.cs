using System;

class TruckDriver
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        double km = double.Parse(Console.ReadLine());
        double price = 0d;
        if (km <= 5000)
        {
            if (season == "Spring" || season == "Autumn") price = 0.75d;
            else if (season == "Summer") price = 0.90d;
            else price = 1.05d;
        }
        else if (km <= 10000)
        {
            if (season == "Spring" || season == "Autumn") price = 0.95d;
            else if (season == "Summer") price = 1.10d;
            else price = 1.25d;
        }
        else price = 1.45d;
        double salary = ((km * price) * 4) * 0.9d;
        Console.WriteLine("{0:F2}", salary);
    }
}