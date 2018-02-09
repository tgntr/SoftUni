using System;


class KnightGame
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var field = new int[n, n];
        for (int row = 0; row < n; row++)
        {
            var input = Console.ReadLine();
            for (int col = 0; col < n; col++)
            {
                field[row, col] = input[col];
            }
        }
        var killedKnights = 0;
        while (true)
        {
            var mostDangerousKnight = 0;
            var mdkRow = 0;
            var mdkCol = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var moveRow = 0;
                    var moveCol = 0;
                    var currentKnightDanger = 0;
                    if (field[row, col] == 'K')
                    {
                        //horizontal up left
                        moveRow = row - 1;
                        moveCol = col - 2;
                        if (IsInsideTheField(moveRow, moveCol, n) && field[moveRow, moveCol] == 'K')
                            currentKnightDanger++;

                        //vertical up left
                        moveRow = row - 2;
                        moveCol = col - 1;
                        if (IsInsideTheField(moveRow, moveCol, n) && field[moveRow, moveCol] == 'K')
                            currentKnightDanger++;

                        //horizontal up right
                        moveRow = row - 1;
                        moveCol = col + 2;
                        if (IsInsideTheField(moveRow, moveCol, n) && field[moveRow, moveCol] == 'K')
                            currentKnightDanger++;

                        //vertical up right
                        moveRow = row - 2;
                        moveCol = col + 1;
                        if (IsInsideTheField(moveRow, moveCol, n) && field[moveRow, moveCol] == 'K')
                            currentKnightDanger++;

                        //horizontal down left
                        moveRow = row + 1;
                        moveCol = col - 2;
                        if (IsInsideTheField(moveRow, moveCol, n) && field[moveRow, moveCol] == 'K')
                            currentKnightDanger++;

                        //vertical down left
                        moveRow = row + 2;
                        moveCol = col - 1;
                        if (IsInsideTheField(moveRow, moveCol, n) && field[moveRow, moveCol] == 'K')
                            currentKnightDanger++;

                        //horizontal down right
                        moveRow = row + 1;
                        moveCol = col + 2;
                        if (IsInsideTheField(moveRow, moveCol, n) && field[moveRow, moveCol] == 'K')
                            currentKnightDanger++;

                        //vertical down right
                        moveRow = row + 2;
                        moveCol = col + 1;
                        if (IsInsideTheField(moveRow, moveCol, n) && field[moveRow, moveCol] == 'K')
                            currentKnightDanger++;
                    }
                    if (currentKnightDanger > mostDangerousKnight)
                    {
                        mostDangerousKnight = currentKnightDanger;
                        mdkRow = row;
                        mdkCol = col;
                    }
                }
            }
            if (mostDangerousKnight == 0)
            {
                Console.WriteLine(killedKnights);
                break;
            }
            else
            {
                field[mdkRow, mdkCol] = '0';
                killedKnights++;
                mostDangerousKnight = 0;
            }
        }
    }

    static bool IsInsideTheField(int row, int col, int n)
    {
        return row >= 0 && row < n && col >= 0 && col < n;
    }
}