using System;
using System.Collections.Generic;

namespace _07.BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            var queue = new Queue<char>(input);
            var openingBrackets = new Stack<char>();
            while (queue.Count > 0)
            {
                var currentBracket = queue.Peek();
                if (currentBracket == '(' || currentBracket == '{' || currentBracket == '[')
                {
                    openingBrackets.Push(currentBracket);
                }
                else
                {
                    var lastOpeningBracket = openingBrackets.Peek();
                    if ((lastOpeningBracket == '(' && currentBracket == ')') ||
                        (lastOpeningBracket == '{' && currentBracket == '}') ||
                        (lastOpeningBracket == '[' && currentBracket == ']'))
                    {
                        openingBrackets.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                queue.Dequeue();
            }
            Console.WriteLine("YES");
        }
    }
}
