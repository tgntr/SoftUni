using System;

class MegaPixels
{
    static void Main()
    {
        decimal width = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());
        decimal megaPixels =(width * height) / 1000000;
        decimal rounded = Math.Round(megaPixels, 1);
        Console.WriteLine("{0}x{1} => {2}MP", width, height, rounded);
    }
}

