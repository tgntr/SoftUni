using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.HotPotatoe
{
    class HotPotatoe
    {
        static void Main()
        {
            var players = Console.ReadLine().Split();
            var tosses = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(players);

            while (queue.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
