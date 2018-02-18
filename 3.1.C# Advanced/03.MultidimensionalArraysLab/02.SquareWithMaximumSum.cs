using System;
using System.Linq;

namespace _02.SquareWithMaximumSum
{
    class SquareWithMaximumSum
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[rowsCols[0], rowsCols[1]];

            for (int row = 0; row < rowsCols[0]; row++)
            {
                var inputNumbers = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.None)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < rowsCols[1]; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }

            var biggestSum = int.MinValue;
            var biggestRow = 0;
            var biggestCol = 0;
            for (int i = 0; i < rowsCols[0] - 1; i++)
            {
                
                var currentSum = 0;
                for (int y = 0; y < rowsCols[1] - 1; y++)
                {
                    currentSum = matrix[i, y] 
                        + matrix[i, y + 1] 
                        + matrix[i + 1, y] 
                        + matrix[i + 1, y + 1];

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        biggestRow = i;
                        biggestCol = y;
                    }
                }
            }

            Console.WriteLine($"{matrix[biggestRow,biggestCol]} {matrix[biggestRow, biggestCol+1]} " +
                $"\n{matrix[biggestRow+1, biggestCol]} {matrix[biggestRow+1, biggestCol+1]} " +
                $"\n{biggestSum}");
        }
    }
}
