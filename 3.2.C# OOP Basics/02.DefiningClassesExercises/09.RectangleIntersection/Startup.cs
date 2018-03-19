using System;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var rectangles = new Dictionary<string, Rectangle>();

        var input = Console.ReadLine().Split();

        var n = int.Parse(input[0]);
        var m = int.Parse(input[1]);

        for (int i = 0; i < n; i++)
        {
            var rectangle = new Rectangle(Console.ReadLine());
            rectangles.Add(rectangle.Id, rectangle);
        }

        for (int i = 0; i < m; i++)
        {
            var rectanglesToCheck = Console.ReadLine().Split();
            var firstRectangle = rectangles[rectanglesToCheck[0]];
            var secondRectangle = rectangles[rectanglesToCheck[1]];

            Console.WriteLine(firstRectangle.Intersect(secondRectangle));
        }
    }
}
