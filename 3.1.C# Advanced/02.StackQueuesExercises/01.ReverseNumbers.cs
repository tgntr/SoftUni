using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine().Trim();
            if (input == "")
            {
                Console.WriteLine(input);
                return;
            }
            var numbers = input.Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);
            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
    }
}
