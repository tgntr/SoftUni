using System;

class HousePainting
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double firstWall = x * y;
        double window = 1.5 * 1.5;
        double firstTotal = (2 * firstWall) - (2 * window);
        double secondWall = x * x;
        double entry = 1.2 * 2;
        double secondTotal = (2 * secondWall) - entry;
        double green = (firstTotal + secondTotal) / 3.4;
        double rectangles = 2 * (x * y);
        double triangles = 2 * (x * h / 2);
        double red = (rectangles + triangles) / 4.3;
        Console.WriteLine("{0:F2} \n{1:F2}", green, red);
    }
}
