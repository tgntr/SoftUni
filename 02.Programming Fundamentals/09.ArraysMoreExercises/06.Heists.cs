using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] prices = Console.ReadLine().Split(' ');
        int priceOfJewels = int.Parse(prices[0]);
        int priceOfGold = int.Parse(prices[1]);
        string[] heist = new string[2];
        long expenses = 0;
        long income = 0;
        while (heist[0] != "Jail")
        {
            heist = Console.ReadLine().Split(' ');
            if (heist[0] == "Jail")
            {
                break;
            }
            char[] loot = heist[0].ToCharArray();
            income += ValueOfLoot(loot, priceOfJewels, priceOfGold);
            expenses += int.Parse(heist[1]);
        }
        income -= expenses;
        PrintOutcome(income);
    }
    static int ValueOfLoot(char[] loot, int priceOfJewels, int priceOfGold)
    {
        int income = 0;
        for (int i = 0; i < loot.Length; i++)
        {
            if (loot[i] == '%')
            {
                income += priceOfJewels; 
            }
            else if (loot[i] == '$')
            {
                income += priceOfGold;
            }
        }
        return income;
    }
    static void PrintOutcome(long income)
    {
        if (income < 0)
        {
            Console.WriteLine($"Have to find another job. Lost: {Math.Abs(income)}.");
        }
        else
        {
            Console.WriteLine($"Heists will continue. Total earnings: {income}.");
        }
    }
}
