using System;
using System.Collections.Generic;

namespace _05.CalculateSequenceWithQueue
{
    class CalcualateSequenceWithQueue
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(n);
            for (int i = 0; i < 50; i++)
            {
                var s = queue.Peek();
                queue.Enqueue(s + 1);
                queue.Enqueue(2 * s + 1);
                queue.Enqueue(s + 2);
                Console.Write($"{queue.Dequeue()} ");
            }
           
        }
    }
}
