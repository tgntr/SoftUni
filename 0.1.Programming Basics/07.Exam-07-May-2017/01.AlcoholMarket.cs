using System;

class AlcoholMarket
{
    static void Main()
    {
        double priceWhiskey = double.Parse(Console.ReadLine());
        double beer = double.Parse(Console.ReadLine());
        double wine = double.Parse(Console.ReadLine());
        double rakia = double.Parse(Console.ReadLine());
        double whiskey = double.Parse(Console.ReadLine());
        double priceRakia = (priceWhiskey / 2);
        double totalWine = (priceRakia - (0.4 * priceRakia)) * wine;
        double totalBeer = (priceRakia - (priceRakia * 0.8)) * beer;
        double totalWhiskey = priceWhiskey * whiskey;
        double totalRakia = priceRakia * rakia;
        double totalPrice = totalRakia + totalWine + totalBeer + totalWhiskey;

        Console.WriteLine("{0:F2}", totalPrice);
    }
}

