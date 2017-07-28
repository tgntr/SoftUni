using System;

class StyroFoam
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double houseSize = double.Parse(Console.ReadLine());
        int windows = int.Parse(Console.ReadLine());
        double packSize = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double size = (houseSize - (windows * 2.4d)) * 1.1;
        double need = Math.Ceiling(size / packSize) * price;
        if (need > budget) Console.WriteLine("Need more: {0:F2}", need - budget);
        else
        {
            Console.WriteLine("Spent: {0:F2}\nLeft: {1:F2}", need, budget - need);
        }
    }
}
