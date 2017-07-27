using System;

class VegetablesShop
{
    static void Main()
    {
        double priceFruits = double.Parse(Console.ReadLine());
        double priceVegetables = double.Parse(Console.ReadLine());
        int quantityFruits = int.Parse(Console.ReadLine());
        int quantityVegetables = int.Parse(Console.ReadLine());
        double price = (priceFruits * quantityFruits) + (priceVegetables * quantityVegetables);
        Console.WriteLine(price / 1.94);
    }
}