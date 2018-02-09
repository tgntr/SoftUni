using System;
using System.Collections.Generic;

namespace _06.TrafficLight
{
    class TrafficLight

    {
        static void Main()
        {
            var carsPerLight = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var queue = new Queue<string>();
            var carsPassed = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    var carsToPass = Math.Min(carsPerLight, queue.Count);
                    for (int i = 0; i < carsToPass; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        carsPassed++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
