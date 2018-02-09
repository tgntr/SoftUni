using System;

namespace _01.DangerousFloor
{
    class DangerousFloor
    {
        static void Main()
        {
            var rows = 8;
            var field = new string[rows][];
            for (int row = 0; row < rows; row++)
                field[row] = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var pieceType = input[0];
                var pieceRow = int.Parse(input[1].ToString());
                var pieceCol = int.Parse(input[2].ToString());
                var moveRow = int.Parse(input[4].ToString());
                var moveCol = int.Parse(input[5].ToString());

                if (field[pieceRow][pieceCol] != pieceType.ToString())
                {
                    Console.WriteLine("There is no such a piece!");
                }
                else if (!IsOutside(moveRow, moveCol) && !MoveIsValid(pieceType, pieceRow, pieceCol, moveRow, moveCol))
                {
                    Console.WriteLine("Invalid move!");
                }
                else if (IsOutside(moveRow, moveCol))
                {
                    Console.WriteLine("Move go out of board!");
                }
                else
                {
                    field[moveRow][moveCol] = pieceType.ToString();
                    field[pieceRow][pieceCol] = "x";
                }
            }
        }

        private static bool MoveIsValid(char pieceType, int pieceRow, int pieceCol, int moveRow, int moveCol)
        {
            
            if (pieceType == 'K')
                if (Math.Abs(pieceRow - moveRow) <= 1 && Math.Abs(pieceCol - moveCol) <= 1)
                    return true;
            else if (pieceType == 'R')
                if (pieceRow == moveRow || pieceCol == moveCol)
                    return true;
            else if (pieceType == 'B')
                if (Math.Abs(pieceRow - moveRow) == Math.Abs(pieceCol - moveCol))
                    return true;
            else if (pieceType == 'Q')
                if (Math.Abs(pieceRow - moveRow) == Math.Abs(pieceCol - moveCol)
                  || pieceRow == moveRow || pieceCol == moveCol)
                    return true;
            else
                if (moveCol == pieceCol && moveRow == pieceRow - 1)
                    return true;
            return false;
        }

        static bool IsOutside(int row, int col)
        {
            return row < 0 || row >= 8 || col < 0 || col >= 8;
        }
    }
}
