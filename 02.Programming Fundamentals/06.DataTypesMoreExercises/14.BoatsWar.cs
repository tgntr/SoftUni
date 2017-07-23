using System;

class BoatsWar
{
    static void Main()
    {
        char firstBoat = Convert.ToChar(Console.ReadLine());
        char secondBoat = Convert.ToChar(Console.ReadLine());
        int firstBoatTiles = 0;
        int secondBoatTiles = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            string input = Console.ReadLine();
            if (input == "UPGRADE")
            {
                //int element = Convert.ToInt32(firstBoat);
                firstBoat = (char)(firstBoat + 3);
                //element = Convert.ToInt32(secondBoat);
                secondBoat = (char)(secondBoat + 3);
            }
            else if (i % 2 == 1)
            {
                firstBoatTiles += input.Length;
            }
            else
            {
                secondBoatTiles += input.Length;
            }
            if (firstBoatTiles >= 50 || secondBoatTiles >= 50)
            {
                break;
            }
        }
        if (firstBoatTiles > secondBoatTiles)
        {
            Console.WriteLine(firstBoat);
        }
        else
        {
            Console.WriteLine(secondBoat);
        }
    }
}
