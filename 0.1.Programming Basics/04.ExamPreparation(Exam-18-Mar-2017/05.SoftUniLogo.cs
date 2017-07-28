using System;

class SoftUniLogo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = (4 * n) - 2;
        int width = (12 * n) - 5;

        DrawRoof(height, width);
        DrawBottom(height, width);
    }
    static void DrawRoof(int height, int width)
    {

        bool isRoof = true;
        for (int i = 0; i < (height / 2) + 1; i++)
        {
            int currentElement = ElementsStep(height, width, isRoof, i);
            int currentDots = DotsStep(height, width, isRoof, i);
            Draw(currentElement, currentDots, isRoof);
        }
    }
    static void DrawBottom(int height, int width)
    {
        bool isRoof = false;
        int half = (((height / 2) - 1) / 2);
        for (int i = 1; i <= half; i++)
        {
            int currentElement = ElementsStep(height, width, isRoof, i);
            int currentDots = DotsStep(height, width, isRoof, i);
            Draw(currentElement, currentDots, isRoof);
            if (i == half)
            {
                DrawRoot(currentElement, currentDots, half, isRoof);
            }
        }

    }
    static int IncreasingStep(int height, int width)
    {
        int increasingWith = width / (height / 2);
        return increasingWith;
    }
    static int ElementsStep(int height, int width, bool isRoof, int i)
    {
        int currentElement = 0;
        if (isRoof)
        {
            currentElement = (i * IncreasingStep(height, width)) + 1;
        }
        else
        {
            currentElement = width - (i * IncreasingStep(height, width));
        }
        return currentElement;
    }
    static int DotsStep(int height, int width, bool isRoof, int i)
    {
        int currentDots = (width - (ElementsStep(height, width, isRoof, i))) / 2;
        return currentDots;
    }

    static void Draw(int currentElement, int currentDots, bool isRoof)
    {
        string draw = "";

        if (isRoof)
        {
            draw = new string('.', currentDots) + new string('#', currentElement) +
                new string('.', currentDots);
        }
        else
        {
            draw = '|' + new string('.', currentDots - 1) + new string('#', currentElement) +
                new string('.', currentDots);
        }
        Console.WriteLine(draw);
    }
    static void DrawRoot(int currentElement, int currentDots, int half, bool isRoof)
    {
        for (int i = 1; i <= half; i++)
        {
            if (i == half)
            {
                string draw = '@' + new string('.', currentDots - 1) + new string('#', currentElement) +
                new string('.', currentDots);
                Console.WriteLine(draw);
            }
            else
            {
                Draw(currentElement, currentDots, isRoof);
            }
        }
    }
}