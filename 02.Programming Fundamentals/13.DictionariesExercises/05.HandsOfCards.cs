using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards
{
    static void Main()
    {
        var input = Console.ReadLine().Split(':').ToList();
        string playerName = input[0];
        var players = new Dictionary<string, List<string>>();
        while (playerName != "JOKER")
        {
            if (!players.ContainsKey(playerName))
            {
                players[playerName] = new List<string>();
            }
            var cards = input[1].Split(',', ' ').Select(x => x.Trim()).Where(x => x != "").ToList();
            players[playerName].AddRange(cards);
            players[playerName] = players[playerName].Distinct().ToList();
            input = Console.ReadLine().Split(':').ToList();
            playerName = input[0];
        }
        foreach (var player in players.Keys)
        {
            Console.WriteLine($"{player}: {HandValue(players[player])}");
        }
    }
    static int HandValue(List<string> cards)
    {
        int handValue = 0;
        foreach (var card in cards)
        {
            var elements = card.ToCharArray();
            int power = 0;
            if (elements.Length == 3)
            {
                power = int.Parse(elements[0] + "" + elements[1]);
            }
            else if (Char.IsDigit(elements[0]))
            {
                power = int.Parse(elements[0].ToString());
            }
            else if (elements[0] == 'J')
            {
                power = 11;
            }
            else if (elements[0] == 'Q')
            {
                power = 12;
            }
            else if (elements[0] == 'K')
            {
                power = 13;
            }
            else if (elements[0] == 'A')
            {
                power = 14;
            }
            int multiplier = 0;
            if (elements.Last() == 'S')
            {
                multiplier = 4;
            }
            else if (elements.Last() == 'H')
            {
                multiplier = 3;
            }
            else if (elements.Last() == 'D')
            {
                multiplier = 2;
            }
            else if (elements.Last() == 'C')
            {
                multiplier = 1;
            }
            handValue += power * multiplier;
        }
        return handValue;
    }
}