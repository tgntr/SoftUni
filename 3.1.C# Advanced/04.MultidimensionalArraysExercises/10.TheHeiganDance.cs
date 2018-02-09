using System;

namespace TheHeiganDance
{
    class TheHeiganDance
    {
        static void Main()
        {
            var leftWall = -1;
            var rightWall = 15;
            var bottomWall = 15;
            var topWall = -1;

            var playerRow = 7;
            var playerCol = 7;
            var playerHealth = 18500;
            var playerDamage = double.Parse(Console.ReadLine());

            var heiganHealth = 3000000d;
            var plagueCloud = 3500;
            var eruption = 6000;
            var plague = false;
            while (playerHealth > 0 && heiganHealth > 0)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var spell = input[0];
                var shotRow = int.Parse(input[1]);
                var shotCol = int.Parse(input[2]);
                heiganHealth -= playerDamage;
                if (plague)
                {
                    playerHealth -= plagueCloud;
                    plague = false;

                    if (playerHealth <= 0 && heiganHealth <= 0)
                    {
                        Console.WriteLine($"Heigan: Defeated!" +
                            $"\nPlayer: Killed by Plague Cloud" +
                            $"\nFinal position: {playerRow}, {playerCol}");
                        return;
                    }
                    if (playerHealth <= 0)
                    {
                        Console.WriteLine($"Heigan: {heiganHealth:F2}" +
                            $"\nPlayer: Killed by Plague Cloud" +
                            $"\nFinal position: {playerRow}, {playerCol}");
                        return;
                    }
                }

                if (heiganHealth <= 0)
                {
                    Console.WriteLine($"Heigan: Defeated!" +
                        $"\nPlayer: {playerHealth}" +
                        $"\nFinal position: {playerRow}, {playerCol}");
                    return;
                }

                var isInside = playerRow <= shotRow + 1 && playerRow >= shotRow - 1 && playerCol <= shotCol + 1 && playerCol >= shotCol - 1;
                if (isInside)
                {
                    playerRow--;
                    isInside = playerRow <= shotRow + 1 && playerRow >= shotRow - 1 && playerCol <= shotCol + 1 && playerCol >= shotCol - 1;
                    if (playerRow == topWall || isInside)
                    {
                        playerRow++;
                        playerCol++;
                        isInside = playerRow <= shotRow + 1 && playerRow >= shotRow - 1 && playerCol <= shotCol + 1 && playerCol >= shotCol - 1;
                        if (playerCol == rightWall || isInside)
                        {
                            playerCol--;
                            playerRow++;
                            isInside = playerRow <= shotRow + 1 && playerRow >= shotRow - 1 && playerCol <= shotCol + 1 && playerCol >= shotCol - 1;
                            if (playerCol == bottomWall || isInside)
                            {
                                playerRow--;
                                playerCol--;
                                isInside = playerRow <= shotRow + 1 && playerRow >= shotRow - 1 && playerCol <= shotCol + 1 && playerCol >= shotCol - 1;
                                if (playerCol == leftWall || isInside)
                                {
                                    playerCol++;
                                    if (spell == "Cloud")
                                    {
                                        playerHealth -= plagueCloud;
                                        plague = true;
                                        spell = "Plague Cloud";
                                    }
                                    else
                                    {
                                        playerHealth -= eruption;
                                    }

                                    if (playerHealth <= 0)
                                    {
                                        Console.WriteLine($"Heigan: {heiganHealth:F2}" +
                                            $"\nPlayer: Killed by {spell}" +
                                            $"\nFinal position: {playerRow}, {playerCol}");
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
