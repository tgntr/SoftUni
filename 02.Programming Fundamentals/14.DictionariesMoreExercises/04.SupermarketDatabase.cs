using System;
using System.Collections.Generic;
using System.Linq;

class SupermarketDatabase
{
    static void Main()
    {
        var stocks = new Dictionary<string, List<double>>();
        string input = Console.ReadLine();
        while (input != "stocked")
        {
            string product = input.Split()[0];
            double price = double.Parse(input.Split()[1]);
            double quantity = double.Parse(input.Split()[2]);
            if (!stocks.ContainsKey(product))
            {
                stocks[product] = new List<double>(2);
                stocks[product].Add(0);
                stocks[product].Add(0);
            }
            stocks[product][0] = price;
            stocks[product][1] += quantity;
            input = Console.ReadLine();
        }
        double totalPrice = 0;
        foreach (var product in stocks.Keys)
        {
            var price = stocks[product][0];
            var quantity = stocks[product][1];
            totalPrice += price * quantity;
            Console.WriteLine($"{product}: ${price:F2} * {quantity} = ${price*quantity:F2}");
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${totalPrice:F2}");
    }
}

