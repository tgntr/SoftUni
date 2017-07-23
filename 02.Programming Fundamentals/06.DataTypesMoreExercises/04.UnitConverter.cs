using System;

class Program
{
    static void Main()
    {
        string imperialUnit = Console.ReadLine();
        double number = double.Parse(Console.ReadLine());
        double converted = 0;
        string metricUnit = "";
        if (imperialUnit == "miles")
        {
            converted = number * 1.6;
            metricUnit = "kilometers";
        }
        else if (imperialUnit == "inches")
        {
            converted = number * 2.54;
            metricUnit = "centimeters";
        }
        else if (imperialUnit == "feet")
        {
            converted = number * 30;
            metricUnit = "centimeters";
        }
        else if (imperialUnit == "yards")
        {
            converted = number * 0.91;
            metricUnit = "meters";

        }
        else if (imperialUnit == "gallons")
        {
            converted = number * 3.8;
            metricUnit = "liters";
        }
        Console.WriteLine("{0} {1} = {2:F2} {3}", number, imperialUnit, converted, metricUnit);
    }
}