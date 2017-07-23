using System;

class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double diff = Math.Abs(a - b);
        bool equal = false;
        if (diff < eps)
        {
            equal = true;
        }
        Console.WriteLine(equal);
    }
}
