using System;

class Bills
{
    static void Main()
    {
        int months = int.Parse(Console.ReadLine());
        double readline = 0d;
        double electricity = 0d;
        double water = 0d;
        double internet = 0d;
        double other = 0d;
        for (int i = 0; i < months; i++)
        {
            readline = double.Parse(Console.ReadLine());
            electricity += readline;
            water += 20;
            internet += 15;
            other += (35 + readline) * 1.2;
        }
        double average = (electricity + water + internet + other) / months;
        Console.WriteLine("Electricity: {0:F2} lv \nWater: {1:F2} lv \nInternet: {2:F2} lv \nOther: {3:F2} lv " +
                          "\nAverage: {4:F2} lv", electricity, water, internet, other, average);
    }
}