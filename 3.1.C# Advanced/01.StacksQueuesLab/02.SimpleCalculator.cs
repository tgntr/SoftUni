using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Reverse();
            var stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                var leftNumber = int.Parse(stack.Pop());
                var op = stack.Pop();
                var rightNumber = int.Parse(stack.Pop());
                if (op == "+")
                {
                    stack.Push((leftNumber + rightNumber).ToString());
                }
                else
                {
                    stack.Push((leftNumber - rightNumber).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
