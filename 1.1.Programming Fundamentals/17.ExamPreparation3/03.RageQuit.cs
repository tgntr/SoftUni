using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main()
    {
        var numbersPattern = new Regex(@"([\d]+)+");
        var messagesPattern = new Regex(@"([^\d]+)+");
        var input = Console.ReadLine();
        var numbers = (from Match m in numbersPattern.Matches(input) select m.Value).Select(int.Parse).ToList();
        var messages = (from Match m in messagesPattern.Matches(input) select m.Value).ToList();
        var message = new StringBuilder();
        for (int i = 0; i < messages.Count; i++)
        {
            for (int y  = 0; y < numbers[i]; y++)
            {
                message.Append(messages[i]);
            }
        }
        var uniqueSymbols = message.ToString().ToUpper().Distinct().Count();
        Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
        Console.WriteLine(message.ToString().ToUpper());
    }
}