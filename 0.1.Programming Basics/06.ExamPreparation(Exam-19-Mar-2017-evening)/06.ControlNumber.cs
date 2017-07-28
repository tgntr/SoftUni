using System;

class ControlNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int control = int.Parse(Console.ReadLine());
        int sum = 0;
        int moves = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int y = m; y >= 1; y--)
            {
                sum += (i * 2) + (y * 3);
                moves++;
                if (sum >= control) break;

            }
            if (sum >= control) break;
        }
        if (sum >= control) Console.WriteLine("{0} moves \nScore: {1} >= {2}", moves, sum, control);
        else Console.WriteLine("{0} moves", moves);


    }
}