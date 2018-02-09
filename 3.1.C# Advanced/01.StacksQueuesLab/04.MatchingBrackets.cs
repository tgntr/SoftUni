using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            var stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if(input[i] == ')')
                {
                    for (int y = stack.Pop(); y <= i; y++)
                    {
                        Console.Write(input[y]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
