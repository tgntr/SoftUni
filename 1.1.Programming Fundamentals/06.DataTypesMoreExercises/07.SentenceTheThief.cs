using System;

class SentenceTheThief
{
    static void Main()
    {
        string type = Console.ReadLine();
        long minValue = 0;
        long maxValue = 0;

        if (type == "sbyte")
        {
            minValue = sbyte.MinValue;
            maxValue = sbyte.MaxValue;
        }
        else if (type == "int")
        {
            minValue = int.MinValue;
            maxValue = int.MaxValue;
        }
        else
        {
            minValue = long.MinValue;
            maxValue = long.MaxValue;
        }
        int amountOfIDs = int.Parse(Console.ReadLine());
        decimal currentSuspect = 0;
        decimal currentClosest = decimal.MaxValue;
        for (int i = 0; i < amountOfIDs; i++)
        {

            decimal ID = decimal.Parse(Console.ReadLine());

            if (maxValue - ID < currentClosest && ID <= maxValue)
            {
                currentClosest = maxValue - ID;
                currentSuspect = ID;
            }
        }
        decimal years = 0;
        if (currentSuspect < 0)
        {
            years = Math.Ceiling(Math.Abs(currentSuspect / 128));
        }
        else
        {
            years = Math.Ceiling(Math.Abs(currentSuspect / 127));
        }
        if (years > 1)
        {
            Console.WriteLine($"Prisoner with id {currentSuspect} is sentenced to {years} years");
        }
        else
        {
            Console.WriteLine($"Prisoner with id {currentSuspect} is sentenced to {years} year");
        }
    }
}
