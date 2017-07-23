using System;

class FightGame
{
    static void Main()
    {
        int peshoDmg = int.Parse(Console.ReadLine());
        int goshoDmg = int.Parse(Console.ReadLine());
        int peshoHealth = 100;
        int goshoHealth = 100;
        int round = 1;
        while (peshoHealth > 0 && goshoHealth > 0)
        {
            if (round % 2 == 0)
            {
                peshoHealth -= goshoDmg;
                if (peshoHealth <= 0)
                {
                    Console.WriteLine("Gosho won in {0}th round.", round);
                    break;
                }
                else
                {
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHealth);
                }
            }
            else
            {
                goshoHealth -= peshoDmg;
                if (goshoHealth <= 0)
                {
                    Console.WriteLine("Pesho won in {0}th round.", round);
                    break;
                }
                else
                {
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHealth);
                }
            }
            if (round % 3 == 0)
            {
                peshoHealth += 10;
                goshoHealth += 10;
            }



            round++;
        }
    }
}

