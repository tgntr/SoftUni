using System;
using System.Collections.Generic;

namespace _06.TruckTour
{
    class TruckTour
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var petrolQueue = new Queue<int>();
            var distanceQueue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                petrolQueue.Enqueue(int.Parse(input[0]));
                distanceQueue.Enqueue(int.Parse(input[1]));

            }

            var currentIndex = 0;
            var startIndex = -1;
            var count = 0;
            var fuel = 0;
            while (count < n)
            {
                fuel += petrolQueue.Peek() - distanceQueue.Peek();
                if (fuel >= 0)
                {
                    count++;
                    if (count == 1)
                    {
                        startIndex = currentIndex;
                    }
                }
                else
                {
                    count = 0;
                    fuel = 0;
                    startIndex = -1;
                }
                petrolQueue.Enqueue(petrolQueue.Dequeue());
                distanceQueue.Enqueue(distanceQueue.Dequeue());
                currentIndex++;
                if (currentIndex == n)
                {
                    currentIndex = 0;
                }
            }
            Console.WriteLine(startIndex);
        }
    }
}