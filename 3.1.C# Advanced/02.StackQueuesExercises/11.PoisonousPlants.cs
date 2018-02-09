using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PoisonousPlants
{
    class PoisonousPlants
    {
        static void Main()
        {
            var n = Console.ReadLine();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var plants = new Stack<int>(input);
            var alive = new Stack<int>();
            var deadCount = 1;
            var days = -1;
            while (deadCount > 0)
            {
                deadCount = 0;
                days++;
                while (plants.Count > 1)
                {
                    var rightPlant = plants.Pop();
                    var leftPlant = plants.Peek();

                    if (rightPlant > leftPlant)
                    {
                        deadCount++;
                    }
                    else
                    {
                        alive.Push(rightPlant);
                    }
                }
                while (alive.Count > 0)
                {
                    plants.Push(alive.Pop());
                }
            }
            Console.WriteLine(days);
        }
    }
}
