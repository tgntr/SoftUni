using System;

class LongerLine
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());
        LongerCoordinates(x1, y1, x2, y2, x3, y3, x4, y4);

    }

    static void LongerCoordinates(double x1, double y1, double x2, double y2,
        double x3, double y3, double x4, double y4)
    {
        if (Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2) <
            Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4))
        {
            x1 = x3;
            x2 = x4;
            y1 = y3;
            y2 = y4;
        }

        if (Math.Abs(x1) + Math.Abs(y1) > Math.Abs(x2) + Math.Abs(y2))
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
    }
}

