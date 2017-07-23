using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class SoftuniCoffeeOrders
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var totalPrice = 0m;
        for (int i = 0; i < n; i++)
        {
            var pricePerCapsule = decimal.Parse(Console.ReadLine());
            var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            var capsules = decimal.Parse(Console.ReadLine());
            var daysInMonth = (decimal)DateTime.DaysInMonth(date.Year, date.Month);
            var currentPrice = (daysInMonth * capsules) * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            totalPrice += currentPrice;
        }
        Console.WriteLine($"Total: ${totalPrice:F2}");
    }
}
