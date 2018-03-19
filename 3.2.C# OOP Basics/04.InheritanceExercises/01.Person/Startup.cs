using System;

class Startup
{
    static void Main()
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        try
        {
            var child = new Child(name, age);
            Console.WriteLine(child);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
