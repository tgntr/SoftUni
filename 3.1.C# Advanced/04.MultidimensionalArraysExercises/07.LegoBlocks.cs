using System;
using System.Linq;

namespace _07.LegoBlocks
{
    class LegoBlocks
    {
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine());

            var firstLego = new int[rows][];
            var totalElements = 0;
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                firstLego[row] = input;
                totalElements += input.Length;
            }

            var secondLego = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
                    .ToArray();
                secondLego[row] = input;
                totalElements += input.Length;
            }

            var rowLength = firstLego[0].Length + secondLego[0].Length;
            for (int row = 0; row < rows; row++)
            {
                if (firstLego[row].Length + secondLego[row].Length != rowLength)
                {
                    Console.WriteLine($"The total number of cells is: {totalElements}");
                    return;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine($"[{string.Join(", ",firstLego[row])}, {string.Join(", ", secondLego[row])}]");
            }

        }
    }
}
