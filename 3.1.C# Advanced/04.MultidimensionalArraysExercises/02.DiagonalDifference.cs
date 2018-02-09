using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            var matrix = new long[n, n];

            for (long row = 0; row < n; row++)
            {
                var inputNumbers = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                for (long col = 0; col < n; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }

            var leftDiagonal = 0L;
            var rightDiagonal = 0L;

            for (long i = 0; i < n; i++)
            {
                var lastIndex = n - 1;
                leftDiagonal += matrix[i, i];
                rightDiagonal += matrix[i, lastIndex - i];

            }

            Console.WriteLine(Math.Abs(leftDiagonal-rightDiagonal));
        }
    }
}
