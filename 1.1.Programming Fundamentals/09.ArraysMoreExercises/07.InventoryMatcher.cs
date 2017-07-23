using System;
using System.Collections.Generic;
using System.Linq;

class InventoryMatcher
{
    static void Main()
    {
        string[] product = Console.ReadLine().Split(' ');
        long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        string request = "";
        while (request != "done")
        {
            request = Console.ReadLine();
            if (request == "done")
            {
                break;
            }
            PrintProductInformation(request, product, quantity, price);
        }
    }
    static void PrintProductInformation(string request, string[] product, long[] quantity, decimal[] price)
    {
        for (int i = 0; i < product.Length; i++)
        {
            if (product[i] == request)
            {
                Console.WriteLine($"{product[i]} costs: {price[i]}; Available quantity: {quantity[i]}");
                break;
            }
        }
    }
}
