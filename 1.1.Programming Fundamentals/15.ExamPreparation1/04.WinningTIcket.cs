using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class WinningTIcket
{
    static void Main()
    {
        var tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToList();
        foreach (var ticket in tickets)
        {
            CheckTicket(ticket);
        }
    }
    static void CheckTicket(string ticket)
    {
        if (ticket.Length != 20)
        {
            Console.WriteLine("invalid ticket");
            return;
        }
        var left = new string(ticket.Take(10).ToArray());
        var right = new string(ticket.Skip(10).Take(10).ToArray());
        Regex winningTicketPattern = new Regex(@"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}");
        if ((winningTicketPattern.IsMatch(left) && winningTicketPattern.IsMatch(right)))
        {
            var leftMatch = winningTicketPattern.Match(left).ToString();
            var rightMatch = winningTicketPattern.Match(right).ToString();
            if (leftMatch.Length == 10 && rightMatch.Length == 10 && leftMatch[0] == rightMatch[0])
            {
                Console.WriteLine($"ticket \"{ticket}\" - {leftMatch.Length}{leftMatch[0]} Jackpot!");
            }
            else if (leftMatch[0] == rightMatch[0])
            {
                Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftMatch.Length, rightMatch.Length)}{leftMatch[0]}");
            }
            else
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
        else
        {
            Console.WriteLine($"ticket \"{ticket}\" - no match");
        }

    }
}
