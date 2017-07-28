using System;

class Stop
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool down = false;
        bool left = true;
        for (int i = 0; i < n + 2; i++)
        {
            DrawSide(n, i, down, left);
            left = false;
            DrawMiddle(n, i, down);
            DrawSide(n, i, down, left);
            left = true;
            Console.WriteLine();
        }
        down = true;
        for (int y = n; y >= 1; y--)
        {
            DrawSide(n, y, down, left);
            left = false;
            DrawMiddle(n, y, down);
            DrawSide(n, y, down, left);
            left = true;
            Console.WriteLine();
        }

    }

    private static void DrawSide(int n, int i, bool down, bool left)
    {
        if (down) i++;
        if (left && ((!down && i < n + 1) || (down && i <= n))) Console.Write(new string('.', (n + 1) - i));
        if (i > 0 && ((!down && left) || (down && !left))) Console.Write("//");
        else if (i > 0) Console.Write("\\\\");
        if (!left && ((!down && i < n + 1) || (down && i <= n))) Console.Write(new string('.', (n + 1) - i));
    }

    private static void DrawMiddle(int n, int i, bool down)
    {
        int midLines = (n * 2) + 1;
        if (i > 0) midLines -= 4;
        if (down) i++;
        if (i == n + 1 && !down)
        {
            int mid = ((midLines + (i * 2)) - 5) / 2;
            Console.Write(new string('_', mid));
            Console.Write("STOP!");
            Console.Write(new string('_', mid));
        }
        else
        {
            Console.Write(new string('_', midLines + (i * 2)));

        }
    }
}