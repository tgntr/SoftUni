using System;

class GameStore
{
    static void Main()
    {
        double moneyStart = double.Parse(Console.ReadLine());
        double money = moneyStart;
        bool outOfMoney = false;
        while (money > 0 || outOfMoney == false)
        {
            string input = Console.ReadLine().ToLower();

            if (input == "outfall 4")
            {
                if (money >= 39.99)
                {
                    money -= 39.99;
                    Console.WriteLine("Bought OutFall 4");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "cs: og")
            {
                if (money >= 15.99)
                {
                    money -= 15.99;
                    Console.WriteLine("Bought CS: OG");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "zplinter zell")
            {
                if (money >= 19.99)
                {
                    money -= 19.99;
                    Console.WriteLine("Bought Zplinter Zell");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "honored 2")
            {
                if (money >= 59.99)
                {
                    money -= 59.99;
                    Console.WriteLine("Bought Honored 2");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "roverwatch")
            {
                if (money >= 29.99)
                {
                    money -= 29.99;
                    Console.WriteLine("Bought RoverWatch");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "roverwatch origins edition")
            {
                if (money >= 39.99)
                {
                    money -= 39.99;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else if (input == "game time")
            {
                if (money > 0)
                {
                    Console.WriteLine("Total spent: ${0:F2}.Remaining: ${1:F2}", moneyStart - money, money);
                }
                else
                {
                    Console.WriteLine("Out of money!");
                }
                break;
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
