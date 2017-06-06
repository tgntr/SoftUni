using System;

class ProductContent
{
    static void Main()
    {
        string name = Console.ReadLine();
        double ml = double.Parse(Console.ReadLine());
        double kcal = double.Parse(Console.ReadLine()) * (ml / 100);
        double sugar = double.Parse(Console.ReadLine()) * (ml / 100);
        Console.WriteLine("{0}ml {1}: \n{2}kcal, {3}g sugars", ml, name, kcal, sugar);

    }
}

