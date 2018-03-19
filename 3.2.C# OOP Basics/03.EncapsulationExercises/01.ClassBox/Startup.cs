using System;

class Startup
{
    static void Main()
    {
        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        try
        {
            var box = new Box(length, width, height);
            Console.WriteLine(box);

        }
        catch(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
