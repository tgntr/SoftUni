using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Problem03
{
    static void Main()
    {
        var regex = new Regex(@"(?:(?<curly>{)|(?<square>\[))[^\d]*(?<number>[\d]+)[^\d]*(?(curly)}|\])");
        var n = int.Parse(Console.ReadLine());
        var input = "";
        var output = "";
        for (int i = 0; i < n; i++)
        {
            input += Console.ReadLine();
        }
        var matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            var blockLength = match.Length;
            var number = match.Groups["number"].Value;
            if (number.Length % 3 != 0)
            {
                continue;
            }
            var threes = number.Length / 3;
            for (int i = 0; i < threes; i++)
            {
                var currentThree = string.Join("", number.Take(3));
                var currentNumber = int.Parse(currentThree) - blockLength;
                number = number.Substring(3);
                output += (char)currentNumber;
            }
        }
        Console.WriteLine(output);
    }
}
