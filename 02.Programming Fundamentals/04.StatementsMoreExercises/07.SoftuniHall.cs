using System;

class SoftuniHall
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int items = int.Parse(Console.ReadLine());
        double subtotal = 0;
        for (int i = 0; i < items; i++)
        {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            if (count > 1)
            {
                name += "s";
            }
            subtotal += price * count;
            Console.WriteLine("Adding {0} {1} to cart.", count, name);
        }
        Console.WriteLine("Subtotal: ${0:F2}", subtotal);
        if (subtotal <= budget)
        {
            Console.WriteLine("Money left: ${0:F2}", budget - subtotal );
        }
        else
        {
            Console.WriteLine("Not enough. We need ${0:F2} more.", subtotal - budget);
        }
    }
}
