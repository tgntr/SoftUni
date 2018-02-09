using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RubiksMatrix
{
    class RubiksMatrix
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var matrix = new int[rowsCols[0], rowsCols[1]];
            var current = 1;
            for (int i = 0; i < rowsCols[0]; i++)
            {
                for (int y = 0; y < rowsCols[1]; y++)
                {
                    matrix[i, y] = current;
                    current++;
                }
            }

            var n = int.Parse(Console.ReadLine());

            for (int z = 0; z < n; z++)
            {
                var input = Console.ReadLine().Split();

                var index = int.Parse(input[0]);
                var moves = int.Parse(input[2]) % rowsCols[0];

                if (input[1] == "down")
                {
                    for (int x = 0; x < moves; x++)
                    {
                        var save = matrix[rowsCols[0] - 1, index];
                        for (int c = rowsCols[0] - 1; c > 0; c--)
                        {
                            matrix[c, index] = matrix[c - 1, index];
                        }
                        matrix[0, index] = save;
                    }

                }
                else if (input[1] == "up")
                {
                    for (int x = 0; x < moves; x++)
                    {
                        var save = matrix[0, index];
                        for (int v = 0; v < rowsCols[0] - 1; v++)
                        {
                            matrix[v, index] = matrix[v + 1, index];
                        }
                        matrix[rowsCols[0] - 1, index] = save;
                    }
                }
                else if (input[1] == "left")
                {
                    for (int x = 0; x < moves; x++)
                    {
                        var save = matrix[index, 0];
                        for (int b = 0; b < rowsCols[1] - 1; b++)
                        {
                            matrix[index, b] = matrix[index, b + 1];
                        }
                        matrix[index, rowsCols[1] - 1] = save;
                    }
                }
                else
                {
                    for (int x = 0; x < moves; x++)
                    {
                        var save = matrix[index, rowsCols[1] - 1];
                        for (int b = rowsCols[1] - 1; b > 0; b--)
                        {
                            matrix[index, b] = matrix[index, b - 1];
                        }
                        matrix[index, 0] = save;
                    }
                }
            }

            for (int r = 0; r < rowsCols[0]; r++)
            {
                for (int t = 0; t < rowsCols[1]; t++)
                {
                    var correctNumber = r * rowsCols[1] + t + 1;
                    if (matrix[r, t] != correctNumber)
                    {
                        var save = matrix[r, t];
                        var row = 0;
                        var col = 0;
                        var foundCorrectNumber = false;
                        for (int i = 0; i < rowsCols[0]; i++)
                        {
                            for (int y = 0; y < rowsCols[1]; y++)
                            {
                                if (matrix[i, y] == correctNumber)
                                {
                                    row = i;
                                    col = y;
                                    foundCorrectNumber = true;
                                    break;
                                }

                            }
                            if (foundCorrectNumber)
                            {
                                break;
                            }
                        }

                        matrix[row, col] = save;
                        matrix[r, t] = correctNumber;
                        Console.WriteLine($"Swap ({r}, {t}) with ({row}, {col})");
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                }
            }
        }
    }
}
