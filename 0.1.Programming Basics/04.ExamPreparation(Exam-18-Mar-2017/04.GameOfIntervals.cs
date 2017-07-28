using System;

class GameOfIntervals
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double points = 0;
        double first = 0;
        double second = 0;
        double third = 0;
        double fourth = 0;
        double fifth = 0;
        double invalid = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 9)
            {
                first++;
                points += 0.2 * num;
            }
            else if (num >= 10 && num <= 19)
            {
                second++;
                points += 0.3 * num;
            }
            else if (num >= 20 && num <= 29)
            {
                third++;
                points += 0.4 * num;
            }
            else if (num >= 30 && num <= 39)
            {
                fourth++;
                points += 50;
            }
            else if (num >= 40 && num <= 50)
            {
                fifth++;
                points += 100;
            }
            else
            {
                invalid++;
                points /= 2;
            }
        }
        first = first * 100 / n;
        second = second * 100 / n;
        third = third * 100 / n;
        fourth = fourth * 100 / n;
        fifth = fifth * 100 / n;
        invalid = invalid * 100 / n;
        Console.WriteLine("{0:F2} \nFrom 0 to 9: {1:F2}% \nFrom 10 to 19: {2:F2}% \nFrom 20 to 29: {3:F2}%" +
            "\nFrom 30 to 39: {4:F2}% \nFrom 40 to 50: {5:F2}% \nInvalid numbers: {6:F2}% "
            , points, first, second, third, fourth, fifth, invalid);
    }
}

