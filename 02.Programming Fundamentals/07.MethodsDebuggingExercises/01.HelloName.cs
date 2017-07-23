using System;

class HelloName
{
    static void Main()
    {
        string name = Console.ReadLine();
        Hello(name);
    }
    static void Hello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}