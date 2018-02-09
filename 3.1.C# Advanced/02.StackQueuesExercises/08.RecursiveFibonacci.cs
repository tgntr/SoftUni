using System;
using System.Collections.Generic;

namespace _08.RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();

            queue.Enqueue(1);
            queue.Enqueue(1);
            var fibonacciNumbers = new Stack<long>(queue);

            while (fibonacciNumbers.Count < n)
            {
                fibonacciNumbers.Push(queue.Dequeue() + queue.Peek());
                queue.Enqueue(fibonacciNumbers.Peek());
            }
            Console.WriteLine(fibonacciNumbers.Peek());

            
        }
    }
}
