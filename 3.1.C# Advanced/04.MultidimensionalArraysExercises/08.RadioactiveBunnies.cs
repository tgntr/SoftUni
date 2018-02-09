using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RadioactiveBunnies
{
    class RadioactiveBunnies
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); ;
            var rows = rowsCols[0];
            var cols = rowsCols[1];
            var field = new char[rows][];
            var playerRow = 0;
            var playerCol = 0;
            var won = false;
            for (int row = 0; row < rows; row++)
            {
                field[row] = Console.ReadLine().ToCharArray();
                if (field[row].Contains('P'))
                {
                    playerRow = row;
                    playerCol = Array.IndexOf(field[row], 'P');
                    field[playerRow][playerCol] = '.';
                }
            }

            var moves = Console.ReadLine();

            for (int move = 0; move < moves.Length; move++)
            {
                var currentPlayerRow = playerRow;
                var currentPlayerCol = playerCol;
                if (moves[move] == 'U')
                    playerRow--;
                else if (moves[move] == 'D')
                    playerRow++;
                else if (moves[move] == 'L')
                    playerCol--;
                else
                    playerCol++;

                var fieldAfterSpread = new char[rows][];
                for (int row = 0; row < rows; row++)
                {
                    fieldAfterSpread[row] = (char[])field[row].Clone();
                }
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (field[row][col] == 'B')
                        {
                            if (row - 1 >= 0)
                                fieldAfterSpread[row - 1][col] = 'B';
                            if (row + 1 < rows)
                                fieldAfterSpread[row + 1][col] = 'B';
                            if (col - 1 >= 0)
                                fieldAfterSpread[row][col - 1] = 'B';
                            if (col + 1 < cols)
                                fieldAfterSpread[row][col + 1] = 'B';
                        }
                    }
                }
                field = fieldAfterSpread;
                
                if (playerRow >= rows || playerRow < 0 || playerCol >= cols || playerCol < 0)
                {
                    won = true;
                    playerRow = currentPlayerRow;
                    playerCol = currentPlayerCol;
                    break;
                }
                if (field[playerRow][playerCol] == 'B')
                {
                    break;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join("", field[row])); 
            }

            if (won)
                Console.WriteLine($"won: {playerRow} {playerCol}");
            else
                Console.WriteLine($"dead: {playerRow} {playerCol}");
        }
    }
}
