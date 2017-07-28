using System;

class Parallelepiped
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = (n * 4) + 4;
        int width = (n * 3) + 1;
        string dotsBefore = "";
        string dotsAfter = "";
        int dotsBef = 0;
        int dotsAft = 0;
        string result = "";
        string element = new string('~', n - 2);
        for (int i = 1; i <= height / 2; i++)
        {
            if (i >= 3)
            {
                dotsBef = i - 2;
                dotsBefore = new string('.', dotsBef);
            }
            dotsAft = width - ((n - 2) + dotsBef + 3);
            if (i == 1) dotsAft++;
            dotsAfter = new string('.', dotsAft);
            if (i == 1) result = '+' + element + '+' + dotsAfter;
            else result = '|' + dotsBefore + '\\' + element + '\\' + dotsAfter;
            Console.WriteLine(result);
        }
        for (int y = 1; y <= height / 2; y++)
        {
            if (y >= 2)
            {
                dotsBef = y - 1;
                dotsBefore = new string('.', dotsBef);
            }
            dotsAft = width - ((n - 2) + dotsBef + 3);
            if (y == height / 2) dotsAft = width - (2 + (n - 2));
            dotsAfter = new string('.', dotsAft);
            if (y == height / 2) result = dotsAfter + '+' + element + '+';
            else if (y == 1) result = '\\' + dotsBefore + '|' + element + '|';
            else result = dotsBefore + '\\' + dotsAfter + '|' + element + '|';
            Console.WriteLine(result);
        }
    }
}