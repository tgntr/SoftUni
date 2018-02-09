using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    class MaximumElement
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maximumElement = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                if (input.Length == 2)
                {
                    stack.Push(int.Parse(input[1]));

                    if (maximumElement.Count == 0 || stack.Peek() >= maximumElement.Peek())
                    {
                        maximumElement.Push(stack.Peek());
                    }
                }
                else if(input[0] == "2")
                {
                    if (stack.Pop() == maximumElement.Peek())
                    {
                        maximumElement.Pop();
                    }
                }
                else
                {
                    Console.WriteLine(maximumElement.Peek());
                }
            }
        }
    }
}
