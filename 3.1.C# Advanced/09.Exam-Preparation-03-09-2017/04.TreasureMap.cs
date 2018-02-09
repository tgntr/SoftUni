using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.TreasureMap
{
    class TreasureMap
    {
        static void Main()
        {
            var pattern = new Regex(@"(?:(?<hash>#)|!)[^!#]*?(?<![a-zA-Z\d])(?<street>[a-zA-Z]{4})(?![a-zA-Z\d])[^!#]*(?<!\d)(?<number>\d{3})-(?<password>\d{4}|\d{6})(?!\d)[^!#]*(?(hash)!|#)");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var matches = pattern.Matches(input);
                var mostInnerMatch = matches[matches.Count/2];
                var streetName = mostInnerMatch.Groups["street"].Value;
                var streetNumber = mostInnerMatch.Groups["number"].Value;
                var password = mostInnerMatch.Groups["password"].Value;
                Console.WriteLine($"Go to str. {streetName} {streetNumber}. Secret pass: {password}.");
            }
        }
    }
}
