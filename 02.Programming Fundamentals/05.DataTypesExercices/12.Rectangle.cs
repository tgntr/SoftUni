using System;

class Rectangle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double perimeter = (a + b) * 2;
        double area = a * b;
        double diagonal = Math.Sqrt((a * a) + (b * b));
        Console.WriteLine("{0} \n{1} \n{2}", perimeter, area, diagonal);
    }
}
