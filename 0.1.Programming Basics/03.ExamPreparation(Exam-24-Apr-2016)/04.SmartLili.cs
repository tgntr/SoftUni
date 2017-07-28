using System;

class SmartLili
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washmashine = double.Parse(Console.ReadLine());
        int pricePerToy = int.Parse(Console.ReadLine());
        int money = 0;
        int toyCount = 0;
        int brother = 0;
        int moneyFromToys = 0;
        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 1) toyCount++;
            else money += 10 * (i / 2);
        }
        brother = age / 2;
        moneyFromToys = toyCount * pricePerToy;
        money = money + moneyFromToys - brother;
        if (money >= washmashine) Console.WriteLine("Yes! {0:F2}", (double)money - washmashine);
        else Console.WriteLine("No! {0:F2}", washmashine - (double)money);
    }
}
