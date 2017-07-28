using System;

class DogHouse
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double sideWalls = a * (a / 2) * 2;
        double backWall = ((a / 2) * (a / 2)) + ((a / 2 * (b - a / 2)) / 2);
        double entry = (a / 5) * (a / 5);
        double frontWall = backWall - entry;
        double totalSize = sideWalls + backWall + frontWall;
        double green = totalSize / 3;
        double red = sideWalls / 5;
        Console.WriteLine("{0:F2} \n{1:F2}", green, red);
    }
}
