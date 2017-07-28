using System;

class GrapeAndRakia
{
    static void Main()
    {
        double size = double.Parse(Console.ReadLine());
        double kg = double.Parse(Console.ReadLine());
        double loss = double.Parse(Console.ReadLine());
        double grape = (size * kg) - loss;
        double rakiaIncome = ((0.45d * grape) / 7.5) * 9.8d;
        double grapeIncome = (0.55d * grape) * 1.5d;
        Console.WriteLine("{0:F2}", rakiaIncome);
        Console.WriteLine("{0:F2}", grapeIncome);
    }
}