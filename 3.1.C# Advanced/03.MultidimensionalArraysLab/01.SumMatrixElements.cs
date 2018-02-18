using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[rowsCols[0], rowsCols[1]];

            var sum = 0;

            for (int row = 0; row < rowsCols[0]; row++)
            {
                var inputNumbers = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.None)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < rowsCols[1]; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                    sum += inputNumbers[col];
                }
            }

            Console.WriteLine(rowsCols[0]);
            Console.WriteLine(rowsCols[1]);
            Console.WriteLine(sum);
        }
    }
}
