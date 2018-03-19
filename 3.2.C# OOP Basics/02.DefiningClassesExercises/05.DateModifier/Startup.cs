using System;

class Startup
{
    static void Main()
    {
        var first = Console.ReadLine();
        var second = Console.ReadLine();

        var dateModifier = new DateModifier(first, second);
        Console.WriteLine(dateModifier.DaysBetween());
    }
}
