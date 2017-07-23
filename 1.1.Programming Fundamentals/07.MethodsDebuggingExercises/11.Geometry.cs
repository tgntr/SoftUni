using System;

class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();
        if (figure == "triangle")
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            AreaOfTriangle(side, height); 
        }
        else if (figure == "square")
        {
            double side = double.Parse(Console.ReadLine());
            AreaOfSquare(side);
        }
        else if (figure == "rectangle")
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            AreaOfRectangle(width, height);
        }
        else if (figure == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);
        }
    }
    static void AreaOfTriangle(double side, double height)
    {
        double triangleArea = 0.50 * (side * height);
        Console.WriteLine($"{triangleArea:F2}");
    }
    static void AreaOfSquare(double side)
    {
        double squareArea = side * side;
        Console.WriteLine($"{squareArea:F2}");
    }
    static void AreaOfRectangle(double width, double height)
    {
        double rectangleArea = width * height;
        Console.WriteLine($"{rectangleArea:F2}");
    }
    static void AreaOfCircle(double radius)
    {
        double circleArea = Math.PI * (radius * radius);
        Console.WriteLine($"{circleArea:F2}");
    }
}
