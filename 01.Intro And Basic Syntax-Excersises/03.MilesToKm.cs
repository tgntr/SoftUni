using System;

class MilesToKm
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double km = a * 1.60934;
        Console.WriteLine("{0:F2}", km);

    }
}

