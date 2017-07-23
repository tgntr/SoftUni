using System;

class DrawX
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            int intervals = n - (i * 2) - 2;
            string draw = new string(' ', i) + 'x' + new string(' ', intervals) + 'x';
            Console.WriteLine(draw);
        }
        string drawMid = new string(' ',  n / 2) + 'x';
        Console.WriteLine(drawMid);
        int bottomIntervals = n / 2;
        for (int y = n/2; y >0; y--)
        {
            bottomIntervals--;
            int intervals = n - (y * 2);
            string draw = new string(' ', bottomIntervals) + 'x' + new string(' ', intervals) + 'x';
            Console.WriteLine(draw);
        }
    }
}
