using System;
using System.Linq;

namespace DungeonsAndCodeWizards
{
	public class StartUp
	{
		// DO NOT rename this file's namespace or class name.
		// However, you ARE allowed to use your own namespaces (or no namespaces at all if you prefer) in other classes.
		public static void Main(string[] args)
		{
            var dungeonMaster = new DungeonMaster();

            var input = "";
            while (!string.IsNullOrEmpty(input = Console.ReadLine()) && !dungeonMaster.IsGameOver())
            {
                try
                {
                    var command = input.Split()[0];

                    var details = input.Split().Skip(1).ToArray();

                    var output = "";

                    if (command == "JoinParty")
                    {
                        output = dungeonMaster.JoinParty(details);
                    }
                    else if (command == "AddItemToPool")
                    {
                        output = dungeonMaster.AddItemToPool(details);
                    }
                    else if (command == "PickUpItem")
                    {
                        output = dungeonMaster.PickUpItem(details);
                    }
                    else if (command == "UseItem")
                    {
                        output = dungeonMaster.UseItem(details);
                    }
                    else if (command == "UseItemOn")
                    {
                        output = dungeonMaster.UseItemOn(details);

                    }

                    else if (command == "GiveCharacterItem")
                    {
                        output = dungeonMaster.GiveCharacterItem(details);

                    }
                    else if (command == "GetStats")
                    {
                        output = dungeonMaster.GetStats();
                    }
                    else if (command == "Attack")
                    {
                        output = dungeonMaster.Attack(details);
                    }
                    else if (command == "Heal")
                    {
                        output = dungeonMaster.Heal(details);
                    }
                    else if (command == "EndTurn")
                    {
                        output = dungeonMaster.EndTurn(details);
                    }
                    else if (command == "IsGameOver")
                    {
                        output = dungeonMaster.IsGameOver().ToString();
                    }
                    if (!string.IsNullOrEmpty(output))
                    {
                        Console.WriteLine(output);

                    }

                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                    {
                        Console.WriteLine($"Parameter Error: {ex.Message}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Operation: {ex.Message}");
                    }
                }
            }

            Console.WriteLine("Final stats:");
            Console.WriteLine(dungeonMaster.GetStats());
		}
	}
}