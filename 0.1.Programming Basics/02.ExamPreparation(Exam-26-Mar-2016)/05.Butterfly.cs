using System;

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rows = (2 * (n - 2)) + 1;
        int cows = (2 * n) - 1;
        string upperMid = "\\ /";
        string downMid = "/ \\";
        for (int i = 1; i <= rows; i++)
        {
            for (int y = 1; y <= cows - 2; y++)
            {
                if (i <= rows / 2)
                {
                    drawUpperSide(cows, upperMid, i, y);
                }
                else if (i > (rows / 2) + 1)
                {
                    drawDownSide(cows, downMid, i, y);
                }
                else if (i == (rows + 1) / 2)
                {
                    drawMiddle(cows, y);
                }
            }
            Console.WriteLine();
        }
    }

    static void drawMiddle(int cows, int y)
    {
        if (y == (cows + 1) / 2) Console.Write('@');
        else Console.Write(' ');
    }

    static void drawDownSide(int cows, string downMid, int i, int y)
    {
        if (y == cows / 2) Console.Write(downMid);
        else if (i % 2 == 0) Console.Write('-');
        else Console.Write('*');
    }

    static void drawUpperSide(int cows, string upperMid, int i, int y)
    {
        if (y == cows / 2) Console.Write(upperMid);
        else if (i % 2 == 1) Console.Write('*');
        else Console.Write('-');
    }
}