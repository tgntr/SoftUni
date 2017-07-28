using System;

class Crown
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int row = (n / 2) + 4;
        int col = (2 * n) - 1;
        int mid = 1;
        int intervals = (col - 3) / 2;
        string draw = "";
        string firstRow = '@' + new string(' ', intervals) + '@' + new string(' ', intervals) + '@';
        intervals = (col - 5) / 2;
        string secondRow = "**" + new string(' ', intervals) + '*' + new string(' ', intervals) + "**";
        Console.WriteLine("{0} \n{1}", firstRow, secondRow);

        for (int i = 1; i <= row - 5; i++)
        {
            intervals = (col - 6 - (i * 2) - mid) / 2;
            if (intervals < 0)
            {
                intervals = 0;
            }

            if (i == row - 5)
            {
                draw = '*' + new string('.', i) + '*' + new string('.', mid) +
                '*' + new string('.', i) + '*';
            }
            else
            {
                draw = '*' + new string('.', i) + '*' + new string(' ', intervals) + '*' + new string('.', mid) +
                '*' + new string(' ', intervals) + '*' + new string('.', i) + '*';
            }
            Console.WriteLine("{0}", draw);
            mid += 2;
        }
        int stars = (col - ((row - 4) * 2) - 3) / 2;
        string bottomRow = '*' + new string('.', row - 4) + new string('*', stars) + '.' + new string('*', stars) +
            new string('.', row - 4) + '*';
        Console.WriteLine(bottomRow);
        string bottom = new string('*', col);
        Console.WriteLine("{0} \n{1}", bottom, bottom);
    }
}