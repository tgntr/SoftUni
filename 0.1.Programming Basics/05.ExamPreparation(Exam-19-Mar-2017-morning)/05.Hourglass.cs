using System;

class Hourglass
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int length = 2 * n + 1;
        int element = n;
        if (n == 3) element = 1;
        for (int i = 1; i <= (length / 2) + 1; i++)
        {
            if (i == 1) Console.WriteLine(new string('*', length));
            else if (i == 2) Console.WriteLine(".*" + new string(' ', length - 4) + "*.");
            else if (i == (length / 2) + 1) Console.WriteLine(new string('.', i - 1) + '*' + new string('.', i - 1));
            else
            {
                element = length - 2 - (2 * (i - 1));
                Console.WriteLine(new string('.', i - 1) + '*' + new string('@', element) + '*' + new string('.', i - 1));

            }
        }
        for (int y = 1; y <= length / 2; y++)
        {
            if (y == length / 2) Console.WriteLine(new string('*', length));
            else if (y == length / 2 - 1) Console.WriteLine(".*" + new string('@', length - 4) + "*.");
            else Console.WriteLine(new string('.', length / 2 - y) + '*' + new string(' ', y - 1) + '@' +
                                   new string(' ', y - 1) + '*' + new string('.', length / 2 - y));
        }
    }
}
