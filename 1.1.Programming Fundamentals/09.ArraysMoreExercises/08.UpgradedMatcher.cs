using System;
using System.Collections.Generic;
using System.Linq;

class UpgradedyMatcher
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
                break; ;
            }
            PrintInformation(request, product, quantity, price);
            quantity = UpdateQuantity(request, product, quantity);
            
        }
    }
    static void PrintInformation(string request, string[] product, long[] quantity, decimal[] price)
    {
        string requestProduct = request.Split(' ')[0];
        long requestQuantity = long.Parse(request.Split(' ')[1]);
        for (int i = 0; i < product.Length; i++)
        {
            long currentQuantity = 0;
            if (product[i] == requestProduct)
            {
                if (i > quantity.Length - 1)
                {
                    currentQuantity = 0;
                }
                else
                {
                    currentQuantity = quantity[i];
                }
                if (currentQuantity < requestQuantity)
                {
                    Console.WriteLine($"We do not have enough {product[i]}");
                }
                else
                {
                    Console.WriteLine($"{requestProduct} x {requestQuantity} costs {(decimal)requestQuantity*price[i]:F2}");
                }
                
            }
        }
    }
    static long[] UpdateQuantity (string request, string[] product, long[]quantity)
    {
        string requestProduct = request.Split(' ')[0];
        long requestQuantity = long.Parse(request.Split(' ')[1]);
        for (int i = 0; i < product.Length; i++)
        {
            if (product[i] == requestProduct)
            {
                if (i > quantity.Length - 1)
                {
                    break;
                }
                if (requestQuantity <= quantity[i])
                { 
                    quantity[i] -= requestQuantity;
                }
            }
        }
        return quantity;
    }
}