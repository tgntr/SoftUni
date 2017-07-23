using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string biggestKeg = "";
        decimal biggestVolume = 0;
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal volume = (decimal)Math.PI * (radius * radius) * height;
            if (volume > biggestVolume)
            {
                biggestKeg = name;
                biggestVolume = volume;
            }
        }
        Console.WriteLine(biggestKeg);
    }
}
