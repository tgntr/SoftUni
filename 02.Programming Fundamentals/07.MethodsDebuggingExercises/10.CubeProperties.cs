using System;

class CubeProperties
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine().ToLower();
        CalculateCubeParameter(side, parameter);
    }
    static void CalculateCubeParameter(double side, string parameter)
    {
        if (parameter == "face")
        {
            double faceDiagonals = Math.Sqrt(2.00 * (side * side));
            Console.WriteLine("{0:F2}", faceDiagonals);
        }
        else if (parameter == "space")
        {
            double spaceDiagonals = Math.Sqrt(3.00 * (side * side));
            Console.WriteLine("{0:F2}", spaceDiagonals);
        }
        else if (parameter == "volume")
        {
            double volume = side * side * side;
            Console.WriteLine("{0:F2}", volume);
        }
        else if (parameter == "area")
        {
            double surfaceArea = 6.00 * (side * side);
            Console.WriteLine("{0:F2}", surfaceArea);
        }
    }
}
