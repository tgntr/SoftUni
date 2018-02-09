using System;
using System.Collections.Generic;
using System.Linq;

class NumberWars
{
    static void Main()
    {
        var firstPlayer = new Queue<KeyValuePair<int, char>>();
        var secondPlayer = new Queue<KeyValuePair<int, char>>();

        var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var card in input)
        {
            var number = int.Parse(card.Substring(0, card.Length - 1));
            var letter = card[card.Length - 1];
            firstPlayer.Enqueue(new KeyValuePair<int, char>(number, letter));
        }
        input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var card in input)
        {
            var number = int.Parse(card.Substring(0, card.Length - 1));
            var letter = card[card.Length - 1];
            secondPlayer.Enqueue(new KeyValuePair<int, char>(number, letter));
        }

        for (int round = 1; round <= 1000000; round++)
        {
            var table = new List<KeyValuePair<int, char>>();
            var firstPlayerWinsHand = false;
            var secondPlayerWinsHand = false;
            var firstPlayerNumberStrength = firstPlayer.Peek().Key;
            var secondPlayerNumberStrength = secondPlayer.Peek().Key;
            table.Add(firstPlayer.Dequeue());
            table.Add(secondPlayer.Dequeue());
            if (firstPlayerNumberStrength == secondPlayerNumberStrength)
            {
                var firstPlayerLetterStrength = 0;
                var secondPlayerLetterStrength = 0;
                while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        firstPlayerLetterStrength += firstPlayer.Peek().Value - ('a' - 1);
                        table.Add(firstPlayer.Dequeue());
                    };
                    for (int i = 0; i < 3; i++)
                    {
                        secondPlayerLetterStrength += secondPlayer.Peek().Value - ('a' - 1);
                        table.Add(secondPlayer.Dequeue());
                    };

                    if (firstPlayerLetterStrength > secondPlayerLetterStrength)
                    {
                        firstPlayerWinsHand = true;
                        break;
                    }
                    else if (firstPlayerLetterStrength < secondPlayerLetterStrength)
                    {
                        secondPlayerWinsHand = true;
                        break;
                    }
                }
            }
            else if (firstPlayerNumberStrength > secondPlayerNumberStrength)
                firstPlayerWinsHand = true;
            else
                secondPlayerWinsHand = true;
            
            if (firstPlayerWinsHand)
            {
                foreach (var hand in table.OrderByDescending(x => x.Key).ThenByDescending(x => x.Value))
                {
                    firstPlayer.Enqueue(hand);
                }
            }
            else if (secondPlayerWinsHand)
            {
                foreach (var hand in table.OrderByDescending(x => x.Key).ThenByDescending(x => x.Value))
                {
                    secondPlayer.Enqueue(hand);
                }
            }

            if (firstPlayer.Count == 0 && secondPlayer.Count == 0)
            {
                Console.WriteLine($"Draw after {round} turns");
                return;
            }
            else if (firstPlayer.Count == 0)
            {
                Console.WriteLine($"Second player wins after {round} turns");
                return;
            }
            else if (secondPlayer.Count == 0)
            {
                Console.WriteLine($"First player wins after {round} turns");
                return;
            }
        }

        if (firstPlayer.Count > secondPlayer.Count)
            Console.WriteLine("First player wins after 1000000 turns");
        else if (secondPlayer.Count > firstPlayer.Count)
            Console.WriteLine("Second player wins after 1000000 turns");
        else
            Console.WriteLine("Draw after 1000000 turns");
    }
}