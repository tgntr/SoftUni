using System;
using System.Linq;

namespace _3.SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            var matrix = new string[rowsCols[0]][];
            for (int i = 0; i < rowsCols[0]; i++)
            {
                matrix[i] = Console.ReadLine().Split();
            }

            var totalSquares = 0;

            for (int row = 0; row < rowsCols[0] - 1; row++)
            {
                for (int col = 0; col < rowsCols[1] - 1; col++)
                {
                    var topLeft = matrix[row][col];
                    var topRight = matrix[row][col + 1];
                    var bottomLeft = matrix[row + 1][col];
                    var bottomRight = matrix[row + 1][col + 1];

                    if (topLeft == topRight && topRight == bottomLeft && bottomLeft == bottomRight)
                    {
                        totalSquares++;
                    }
                }
            }

            Console.WriteLine(totalSquares);
        }
    }
}
