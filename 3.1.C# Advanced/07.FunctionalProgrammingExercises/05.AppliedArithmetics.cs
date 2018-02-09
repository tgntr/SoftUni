using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "add")
                {
                    Func<int, int> add = n => n + 1;
                    numbers = numbers.Select(add).ToArray();
                }
                else if (input == "multiply")
                {
                    Func<int, int> multiply = n => n * 2;
                    numbers = numbers.Select(multiply).ToArray();
                }
                else if (input == "subtract")
                {
                    Func<int, int> subtract = n => n - 1;
                    numbers = numbers.Select(subtract).ToArray();
                }
                else
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
        }
    }
}
