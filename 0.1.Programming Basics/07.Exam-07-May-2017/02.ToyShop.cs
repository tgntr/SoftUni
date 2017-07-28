using System;

class ToyShop
{
    static void Main()
    {
        double priceHoliday = double.Parse(Console.ReadLine());
        int puzzles = int.Parse(Console.ReadLine());
        int dolls = int.Parse(Console.ReadLine());
        int bears = int.Parse(Console.ReadLine());
        int minions = int.Parse(Console.ReadLine());
        int trucks = int.Parse(Console.ReadLine());
        int total = puzzles + dolls + bears + minions + trucks;
        double income = (puzzles * 2.6) + (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);
        if (total >= 50)
        {
            income = income - (0.25 * income);
        }
        income = income - (0.1 * income);
        if (income >= priceHoliday)
        {
            Console.WriteLine("Yes! {0:F2} lv left.", income - priceHoliday);
        }
        else
        {
            Console.WriteLine("Not enough money! {0:F2} lv needed.", priceHoliday - income);
        }

    }
}

