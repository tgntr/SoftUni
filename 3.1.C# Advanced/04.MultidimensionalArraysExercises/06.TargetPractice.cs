using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TargetPractice
{
    class TargetPractice
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            var rows = rowsCols[0];
            var cols = rowsCols[1];
            var snake = Console.ReadLine();
            var field = new char[rows, cols];

            var currentSymbol = 0;
            for (int row = rows - 1; row >= 0; row--)
            {
                if ((rows - row) % 2 != 0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        field[row, col] = snake[currentSymbol % snake.Length];
                        currentSymbol++;
                    }
                }
                else
                {
                    for (int col = 0; col < cols; col++)
                    {
                        field[row, col] = snake[currentSymbol % snake.Length];
                        currentSymbol++;
                    }
                }
            }

            var shot = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            var shotRow = shot[0];
            var shotCol = shot[1];
            var shotRadius = shot[2];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    var a = row - shotRow;
                    var b = col - shotCol;
                    var c = shotRadius;
                    var inside = (a * a) + (b * b) <= (c * c);
                    if (inside)
                    {
                        field[row, col] = ' ';
                    }
                }
            }

            for (int col = 0; col < cols; col++)
            {
                var currentEmptyIndex = -1;
                for (int row = rows-1; row >= 0; row--)
                {
                    if (field[row,col] == ' ')
                    {
                        if (currentEmptyIndex == -1)
                        {
                            currentEmptyIndex = row;
                        }
                    }
                    else
                    {
                        if (currentEmptyIndex > -1)
                        {
                            field[currentEmptyIndex, col] = field[row, col];
                            field[row, col] = ' ';
                            currentEmptyIndex--;
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
