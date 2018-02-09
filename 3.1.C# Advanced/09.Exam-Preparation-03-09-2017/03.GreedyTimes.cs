using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GreedyTimes
{
    class GreedyTimes
    {
        static void Main()
        {
            var bag = new Dictionary<string, Dictionary<string, long>>();
            var gold = "Gold";
            var gem = "Gem";
            var cash = "Cash";
            var capacity = long.Parse(Console.ReadLine());
            Func<string, bool> itemIsGold = i => i.ToLower() == "gold";
            Func<string, bool> itemIsGem = i => i.ToLower().EndsWith("gem") && i.Length > 3;
            Func<string, bool> itemIsCash = i => i.Length == 3;

            var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int index = 0; index < input.Length; index += 2)
            {
                var currentItem = input[index];
                var currentAmount = long.Parse(input[index + 1]);
                var currentAmountInBag = bag.Values.Sum(i => i.Values.Sum());
                if (currentAmount + currentAmountInBag > capacity)
                {
                    continue;
                }
                if (itemIsGold(currentItem))
                {
                    if (!bag.ContainsKey(gold))
                        bag[gold] = new Dictionary<string, long>();
                    if (!bag[gold].ContainsKey(gold))
                        bag[gold][gold] = 0;
                    bag[gold][gold] += currentAmount;
                }
                else if (itemIsGem(currentItem))
                {
                    if (!bag.ContainsKey(gem))
                        bag[gem] = new Dictionary<string, long>();
                    long currentGold;
                    if (bag.ContainsKey(gold))
                        currentGold = bag[gold].Values.Sum();
                    else
                        currentGold = 0;
                    var gemAfterPickup = bag[gem].Values.Sum() + currentAmount;

                    if (gemAfterPickup <= currentGold)
                    {
                        if (!bag[gem].ContainsKey(currentItem))
                            bag[gem][currentItem] = 0;
                        bag[gem][currentItem] += currentAmount;
                    }
                }
                else if (itemIsCash(currentItem))
                {
                    if (!bag.ContainsKey(cash))
                        bag[cash] = new Dictionary<string, long>();
                    long currentGem;
                    if (bag.ContainsKey(gem))
                        currentGem = bag[gem].Values.Sum();
                    else currentGem = 0;
                    var cashAfterPickup = bag[cash].Values.Sum() + currentAmount;

                    if (cashAfterPickup <= currentGem)
                    {
                        if (!bag[cash].ContainsKey(currentItem))
                            bag[cash][currentItem] = 0;
                        bag[cash][currentItem] += currentAmount;
                    }
                }
            }

            foreach (var group in bag.Where(b=>b.Value.Count > 0).OrderByDescending(b => b.Value.Values.Sum()))
            {
                var groupTotalAmount = group.Value.Values.Sum();
                Console.WriteLine($@"<{group.Key}> ${groupTotalAmount}");
                foreach (var item in group.Value.OrderByDescending(i=>i.Key).ThenBy(i=>i.Value))
                {
                    Console.WriteLine($"##{item.Key} - {item.Value}");
                }
            }
        }
    }
}
