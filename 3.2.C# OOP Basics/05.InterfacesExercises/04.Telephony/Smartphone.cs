using System.Linq;

public class Smartphone
    : ICallable, IBrowsable
{
    public void Browse(string site)
    {
        if (site.Any(char.IsDigit))
        {
            System.Console.WriteLine("Invalid URL!");
        }
        else
        {
            System.Console.WriteLine($"Browsing: {site}!");
        }
    }

    public void Call(string number)
    {
        if (number.Any(c=> !char.IsDigit(c)))
        {
            System.Console.WriteLine("Invalid number!");
        }
        else
        {
            System.Console.WriteLine($"Calling... {number}");
        }
    }

    public void CallNumbers(string input)
    {
        input.Split().ToList().ForEach(Call);
    }

    public void BrowseSites(string input)
    {
        input.Split().ToList().ForEach(Browse);
    }
}

