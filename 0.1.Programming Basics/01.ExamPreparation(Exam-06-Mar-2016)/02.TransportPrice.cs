using System;

class TransportPrice
{
	static void Main()
	{
		int km = int.Parse(Console.ReadLine());
		string dayNight = Console.ReadLine().ToLower();
		double bestPrice = double.MaxValue;
		double price = 0d;
		if (dayNight == "day")
		{
			price = 0.70d + (km * 0.79d);
			if (price < bestPrice) bestPrice = price;
		}
		else if (dayNight == "night")
		{
			price = 0.70d + (km * 0.90d);
			if (price < bestPrice) bestPrice = price;
		}
		if (km >= 20)
		{
			price = km * 0.09d;
			if (price < bestPrice) bestPrice = price;
		}
		if (km>= 100)
		{
			price = km * 0.06d;
			if (price < bestPrice) bestPrice = price;
		}
		Console.WriteLine(bestPrice);
	}
}
