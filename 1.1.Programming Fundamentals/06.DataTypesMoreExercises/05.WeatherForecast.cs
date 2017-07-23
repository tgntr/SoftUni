using System;

class Program
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        if (input > Math.Floor(input))
        {
            Console.WriteLine("Rainy");
        }
        else if (input >= sbyte.MinValue && input <= sbyte.MaxValue)
        {
            Console.WriteLine("Sunny");
        }
        else if (input >= int.MinValue && input <= int.MaxValue)
        {
            Console.WriteLine("Cloudy");
        }
        else if (input >= long.MinValue && input <= long.MaxValue)
        {
            Console.WriteLine("Windy");
        }
    }
}