using System;

class Startup
{
    static void Main(string[] args)
    {
        var phone = new Smartphone();
        phone.CallNumbers(Console.ReadLine());
        phone.BrowseSites(Console.ReadLine());
    }
}
