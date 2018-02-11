using System;
using System.Linq;

class Problem02
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var field = new char[n][];
        var nikoladze = 0;
        var playerRow = 0;
        var playerCol = 0;
        var samIsDead = false;
        var nikoladzeIsDead = false;
        for (int row = 0; row < n; row++)
        {
            field[row] = Console.ReadLine().ToCharArray();
            if (field[row].Contains('N'))
            {
                nikoladze = row;
            }
            else if (field[row].Contains('S'))
            {
                playerRow = row;
                playerCol = Array.IndexOf(field[row], 'S');
                field[row][playerCol] = '.';
            }
        }
        var moves = Console.ReadLine();
        var currentMove = 0;
        while (!samIsDead && !nikoladzeIsDead)
        {
            for (int row = 0; row < n; row++)
            {
                int enemyIndex = -1;
                if (field[row].Contains('d'))
                {
                    enemyIndex = Array.IndexOf(field[row], 'd');
                    if (enemyIndex == 0)
                    {
                        field[row][enemyIndex] = 'b';
                    }
                    else
                    {
                        field[row][enemyIndex] = '.';
                        enemyIndex--;
                        field[row][enemyIndex] = 'd';
                    }

                }
                else if (field[row].Contains('b'))
                {
                    enemyIndex = Array.IndexOf(field[row], 'b');
                    if (enemyIndex == field[row].Length - 1)
                    {
                        field[row][enemyIndex] = 'd';
                    }
                    else
                    {
                        field[row][enemyIndex] = '.';
                        enemyIndex++;
                        field[row][enemyIndex] = 'b';
                    }
                }
                if (row == playerRow && enemyIndex > -1)
                {
                    var enemy = field[row][enemyIndex];
                    if (enemy == 'b' && enemyIndex <= playerCol)
                    {
                        samIsDead = true;
                        field[playerRow][playerCol] = 'X';
                    }
                    else if (enemy == 'd' && enemyIndex >= playerCol)
                    {
                        samIsDead = true;
                        field[playerRow][playerCol] = 'X';
                    }
                }
            }

            if (samIsDead)
            {
                break;
            }
            if (moves[currentMove] == 'U')
            {
                playerRow--;
            }
            else if (moves[currentMove] == 'D')
            {
                playerRow++;
            }
            else if (moves[currentMove] == 'L')
            {
                playerCol--;
            }
            else if (moves[currentMove] == 'R')
            {
                playerCol++;
            }
            if (moves[currentMove] != 'W')
            {
                field[playerRow][playerCol] = '.';

            }

            if (field[playerRow].Contains('N'))
            {
                var enemyIndex = Array.IndexOf(field[playerRow], 'N');
                nikoladzeIsDead = true;
                field[playerRow][enemyIndex] = 'X';
                field[playerRow][playerCol] = 'S';
                break;
            }
            currentMove++;
        }
        if (nikoladzeIsDead)
        {
            Console.WriteLine("Nikoladze killed!");
        }
        else
        {
            Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
        }
        foreach (var row in field)
        {
            Console.WriteLine(string.Join("", row));
        }
    }
}
