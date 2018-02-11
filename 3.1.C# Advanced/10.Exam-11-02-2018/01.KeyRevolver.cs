using System;
using System.Collections.Generic;
using System.Linq;

class Problem01
{
    static void Main()
    {
        var bulletCost = int.Parse(Console.ReadLine());
        var barrelSize = int.Parse(Console.ReadLine());
        var bullets = new Stack<int>(Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray());
        var totalBullets = bullets.Count;
        var locks = new Queue<int>(Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray());
        var salary = int.Parse(Console.ReadLine());
        var bulletsAvailable = barrelSize;
        while (bullets.Count > 0 && locks.Count > 0)
        {
            
            var currentBullet = bullets.Peek();
            var currentLock = locks.Peek();
            if (currentBullet <= currentLock)
            {
                Console.WriteLine("Bang!");
                locks.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }
            bullets.Pop();
            bulletsAvailable--;
            if (bulletsAvailable == 0 && bullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
                bulletsAvailable = barrelSize;
            }
        }

        if (locks.Count > 0)
        {
            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        }
        else
        {
            var bulletsUsed = totalBullets - bullets.Count;
            var earned = salary - (bulletsUsed * bulletCost);
            Console.WriteLine($"{bullets.Count} bullets left. Earned ${earned}");
        }
    }
}
