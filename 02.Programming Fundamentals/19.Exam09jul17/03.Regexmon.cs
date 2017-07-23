using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Regexmon
{
    static void Main()
    {
        var input = Console.ReadLine();
        var bojomonPattern = new Regex(@"([a-zA-Z]+-[a-zA-Z]+)");
        var didimonPattern = new Regex(@"([^a-zA-Z\-]+)");
        var match = bojomonPattern.Match(input);
        while (true)
        {
            if (!didimonPattern.IsMatch(input))
            {
                break;
            }
            match = didimonPattern.Match(input);
            Console.WriteLine(match.Groups[1].Value);
            input = input.Substring(match.Groups[1].Index + match.Groups[1].Length);

            if (!bojomonPattern.IsMatch(input))
            {
                break;
            }
            match = bojomonPattern.Match(input);
            Console.WriteLine(match.Groups[1].Value);
            input = input.Substring(match.Groups[1].Index + match.Groups[1].Length);
        }
    }
}
